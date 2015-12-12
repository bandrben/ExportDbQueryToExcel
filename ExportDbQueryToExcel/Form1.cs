using BandR;
using OfficeOpenXml;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace ExportDbQueryToExcel
{
    public partial class Form1 : Form
    {

        private AboutForm aboutForm = null;
        private BackgroundWorker bgw = null;

        private string sep = string.Empty;


        public Form1()
        {
            InitializeComponent();

            toolStripStatusLabel1.Text = "";

            this.FormClosed += Form1_FormClosed;

            LoadSettingsFromRegistry();

            imageBandR.Visible = true;
            imageBandRwait.Visible = false;

            sep = ConfigurationManager.AppSettings["multiSqlSeparator"].SafeTrim();
            sep = GenUtil.NVL(sep, ";;");

            label4.Text = string.Format("SQL Query: (can export batches of sql, use '{0}' to separate queries)", sep);
        }




        private void LoadSettingsFromRegistry()
        {
            var msg = "";
            var json = "";

            if (RegistryHelper.GetRegStuff(out json, out msg) && !json.IsNull())
            {
                var obj = JsonExtensionMethod.FromJson<CustomRegistrySettings>(json);

                tbDBName.Text = obj.dbName;
                tbDBServer.Text = obj.dbServer;
                tbDBUsername.Text = obj.dbUsername;
                tbDBPassword.Text = obj.dbPassword;

                tbSQLQuery.Text = obj.dbQuery;
            }
        }

        private void SaveSettingsToRegistry()
        {
            var msg = "";

            var obj = new CustomRegistrySettings
            {
                dbName = tbDBName.Text.Trim(),
                dbPassword = tbDBPassword.Text.Trim(),
                dbQuery = tbSQLQuery.Text.Trim(),
                dbServer = tbDBServer.Text.Trim(),
                dbUsername = tbDBUsername.Text.Trim()
            };
            var json = JsonExtensionMethod.ToJson(obj);

            RegistryHelper.SaveRegStuff(json, out msg);
        }




        void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (aboutForm != null)
            {
                aboutForm.Dispose();
            }

            SaveSettingsToRegistry();
        }




        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aboutForm == null)
            {
                aboutForm = new AboutForm();
            }

            aboutForm.Show();
            aboutForm.Focus();
        }




        private void DisableFormControls()
        {
            toolStripStatusLabel1.Text = "Running...";

            imageBandR.Visible = false;
            imageBandRwait.Visible = true;

            btnStartSQLQuery.Enabled = false;
        }

        private void EnableFormControls()
        {
            toolStripStatusLabel1.Text = "";

            imageBandR.Visible = true;
            imageBandRwait.Visible = false;

            btnStartSQLQuery.Enabled = true;
        }





        private void btnStartSQLQuery_Click(object sender, EventArgs e)
        {
            DisableFormControls();
            InitCoutBuffer();
            tbStatus.Text = "";

            bgw = new BackgroundWorker();
            bgw.DoWork += new DoWorkEventHandler(bgw_btnStartSQLQuery);
            bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_btnStartSQLQuery_End);
            bgw.ProgressChanged += new ProgressChangedEventHandler(BgwReportProgress);
            bgw.WorkerReportsProgress = true;
            bgw.RunWorkerAsync();

        }

        private void bgw_btnStartSQLQuery(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (tbDBName.Text.IsNull())
                {
                    tcout("DB Name is required.");
                    return;
                }
                else if (tbDBServer.Text.IsNull())
                {
                    tcout("DB Server is required.");
                    return;
                }
                else if (tbSQLQuery.Text.IsNull())
                {
                    tcout("Query is required.");
                    return;
                }

                string sqlConnString = "";

                if (!tbDBUsername.Text.IsNull())
                {
                    sqlConnString = string.Format("Server={0};Database={1};User Id={2};Password={3};",
                        tbDBServer.Text.Trim(),
                        tbDBName.Text.Trim(),
                        tbDBUsername.Text.Trim(),
                        tbDBPassword.Text.Trim());
                }
                else
                {
                    sqlConnString = string.Format("Server={0};Database={1};Trusted_Connection=True;",
                        tbDBServer.Text.Trim(),
                        tbDBName.Text.Trim());
                }

                var queries = tbSQLQuery.Text.Trim().Split(new string[] { sep }, StringSplitOptions.RemoveEmptyEntries);

                var i = 0;

                var ar_dts = new List<DataTable>();
                var ar_cmds = new List<string>();

                foreach (var query in queries.Where(x => x.Trim().Length > 0))
                {
                    i++;
                    string msg = "";
                    DataTable dt = null;

                    if (!SQLHelper.ExecuteQueryDt(sqlConnString, query, out dt, out msg))
                    {
                        tcout("ERROR: " + msg);
                        continue;
                    }

                    if (dt == null || dt.Rows.Count <= 0)
                    {
                        tcout("No data found.");
                        continue;
                    }
                    else
                    {
                        tcout("Rows found", dt.Rows.Count);

                        if (cbExportMultiToSheets.Checked)
                        {
                            ar_dts.Add(dt);
                            ar_cmds.Add(query);
                        }
                    }

                    if (!cbExportMultiToSheets.Checked)
                    {
                        // export to excel
                        var exportFilePath = AppDomain.CurrentDomain.BaseDirectory;
                        exportFilePath = exportFilePath.CombineFS("dbexport_" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + "_" + i.ToString() + ".xlsx");

                        FileInfo newFile = new FileInfo(exportFilePath);

                        using (ExcelPackage package = new ExcelPackage(newFile))
                        {
                            var ws = package.Workbook.Worksheets.Add("Sheet1");

                            ws.Cells["A1"].LoadFromDataTable(dt, true);

                            var ws2 = package.Workbook.Worksheets.Add("Sheet2");
                            ws2.Cells["A1"].Value = query;

                            package.Save();

                            tcout("Records saved to Excel: " + exportFilePath);
                        }
                    }
                }

                if (cbExportMultiToSheets.Checked && ar_dts.Any())
                {
                    // export to excel
                    var exportFilePath = AppDomain.CurrentDomain.BaseDirectory;
                    exportFilePath = exportFilePath.CombineFS("dbexport_" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".xlsx");

                    FileInfo newFile = new FileInfo(exportFilePath);

                    using (ExcelPackage package = new ExcelPackage(newFile))
                    {
                        for (i = 0; i < ar_dts.Count; i++)
                        {
                            var cur_dt = ar_dts[i];
                            var cur_query = ar_cmds[i];

                            var ws = package.Workbook.Worksheets.Add("Sheet" + (i + 1).ToString());

                            ws.Cells["A1"].LoadFromDataTable(cur_dt, true);
                            var cmt = ws.Cells["A1"].AddComment(cur_query, null);
                            cmt.AutoFit = true;
                        }

                        package.Save();

                        tcout("Records saved to Excel: " + exportFilePath);
                    }
                }

            }
            catch (Exception ex)
            {
                tcout("ERROR: " + ex.ToString());
            }
        }

        private void bgw_btnStartSQLQuery_End(object sender, RunWorkerCompletedEventArgs e)
        {
            FlushCoutBuffer();
            EnableFormControls();
        }







        /// <summary>
        /// Combine function params as strings with separator, no line breaks.
        /// </summary>
        public string CombineFnParmsToString(params object[] objs)
        {
            string output = "";
            string delim = ": ";

            for (int i = 0; i < objs.Length; i++)
            {
                if (objs[i] == null) objs[i] = "";
                if (i == objs.Length - 1) delim = "";
                output += string.Concat(objs[i], delim);
            }

            return output;
        }

        /// <summary>
        /// Build message for status window, prepend datetime, append message (already combined with separator), append newline chars.
        /// </summary>
        public string BuildCoutMessage(string msg)
        {
            return string.Format("{0}: {1}\r\n", DateTime.Now.ToLongTimeString(), msg);
        }

        /// <summary>
        /// Standard status dumping function, immediately dumps to status window.
        /// </summary>
        public void cout(params object[] objs)
        {
            tbStatus.AppendText(BuildCoutMessage(CombineFnParmsToString(objs)));
        }

        string tcout_buffer;
        int tcout_counter;

        /// <summary>
        /// Threaded status dumping function, uses buffer to only dump to status window peridocially, batch size configured in app.config.
        /// </summary>
        /// <param name="objs"></param>
        public void tcout(params object[] objs)
        {
            tcout_counter++;
            tcout_buffer += BuildCoutMessage(CombineFnParmsToString(objs));

            var batchSize = 1;

            if (tcout_counter % batchSize == 0)
            {
                bgw.ReportProgress(0, tcout_buffer);
                InitCoutBuffer();
            }
        }

        /// <summary>
        /// Reset status buffer.
        /// </summary>
        private void InitCoutBuffer()
        {
            tcout_counter = 0;
            tcout_buffer = "";
        }

        /// <summary>
        /// Flush status buffer to status window (since using mod operator).
        /// </summary>
        private void FlushCoutBuffer()
        {
            if (!tcout_buffer.IsNull())
            {
                tbStatus.AppendText(tcout_buffer);
                InitCoutBuffer();
            }
        }

        /// <summary>
        /// Threaded callback function, dump input to status window, already formatted with datetime, combined params, and linebreaks.
        /// </summary>
        private void BgwReportProgress(object sender, ProgressChangedEventArgs e)
        {
            tbStatus.AppendText(e.UserState.ToString());
        }



    }
}
