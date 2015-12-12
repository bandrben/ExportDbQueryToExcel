namespace ExportDbQueryToExcel
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb1 = new System.Windows.Forms.TabControl();
            this.tp1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDBPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDBUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDBName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbDBServer = new System.Windows.Forms.TextBox();
            this.tp2 = new System.Windows.Forms.TabPage();
            this.cbExportMultiToSheets = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSQLQuery = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.btnStartSQLQuery = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageBandR = new System.Windows.Forms.PictureBox();
            this.imageBandRwait = new System.Windows.Forms.PictureBox();
            this.tb1.SuspendLayout();
            this.tp1.SuspendLayout();
            this.tp2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBandR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBandRwait)).BeginInit();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tb1.Controls.Add(this.tp1);
            this.tb1.Controls.Add(this.tp2);
            this.tb1.Location = new System.Drawing.Point(12, 27);
            this.tb1.Name = "tb1";
            this.tb1.SelectedIndex = 0;
            this.tb1.Size = new System.Drawing.Size(909, 390);
            this.tb1.TabIndex = 0;
            // 
            // tp1
            // 
            this.tp1.AutoScroll = true;
            this.tp1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tp1.Controls.Add(this.label3);
            this.tp1.Controls.Add(this.tbDBPassword);
            this.tp1.Controls.Add(this.label2);
            this.tp1.Controls.Add(this.tbDBUsername);
            this.tp1.Controls.Add(this.label1);
            this.tp1.Controls.Add(this.tbDBName);
            this.tp1.Controls.Add(this.label16);
            this.tp1.Controls.Add(this.tbDBServer);
            this.tp1.Location = new System.Drawing.Point(4, 25);
            this.tp1.Name = "tp1";
            this.tp1.Size = new System.Drawing.Size(901, 361);
            this.tp1.TabIndex = 0;
            this.tp1.Text = "Connection Info";
            this.tp1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "OPTIONAL: Password";
            // 
            // tbDBPassword
            // 
            this.tbDBPassword.Location = new System.Drawing.Point(6, 146);
            this.tbDBPassword.Name = "tbDBPassword";
            this.tbDBPassword.Size = new System.Drawing.Size(276, 20);
            this.tbDBPassword.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "OPTIONAL: Username";
            // 
            // tbDBUsername
            // 
            this.tbDBUsername.Location = new System.Drawing.Point(6, 107);
            this.tbDBUsername.Name = "tbDBUsername";
            this.tbDBUsername.Size = new System.Drawing.Size(276, 20);
            this.tbDBUsername.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DB Name:";
            // 
            // tbDBName
            // 
            this.tbDBName.Location = new System.Drawing.Point(6, 68);
            this.tbDBName.Name = "tbDBName";
            this.tbDBName.Size = new System.Drawing.Size(276, 20);
            this.tbDBName.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "DB Server:";
            // 
            // tbDBServer
            // 
            this.tbDBServer.Location = new System.Drawing.Point(6, 29);
            this.tbDBServer.Name = "tbDBServer";
            this.tbDBServer.Size = new System.Drawing.Size(276, 20);
            this.tbDBServer.TabIndex = 0;
            // 
            // tp2
            // 
            this.tp2.AutoScroll = true;
            this.tp2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tp2.Controls.Add(this.cbExportMultiToSheets);
            this.tp2.Controls.Add(this.label4);
            this.tp2.Controls.Add(this.tbSQLQuery);
            this.tp2.Controls.Add(this.label39);
            this.tp2.Controls.Add(this.btnStartSQLQuery);
            this.tp2.Controls.Add(this.label32);
            this.tp2.Location = new System.Drawing.Point(4, 25);
            this.tp2.Name = "tp2";
            this.tp2.Size = new System.Drawing.Size(901, 361);
            this.tp2.TabIndex = 6;
            this.tp2.Text = "Export SQL";
            this.tp2.UseVisualStyleBackColor = true;
            // 
            // cbExportMultiToSheets
            // 
            this.cbExportMultiToSheets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbExportMultiToSheets.AutoSize = true;
            this.cbExportMultiToSheets.Location = new System.Drawing.Point(87, 336);
            this.cbExportMultiToSheets.Name = "cbExportMultiToSheets";
            this.cbExportMultiToSheets.Size = new System.Drawing.Size(126, 17);
            this.cbExportMultiToSheets.TabIndex = 7;
            this.cbExportMultiToSheets.Text = "Export multi to sheets";
            this.cbExportMultiToSheets.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(319, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "SQL Query: (can export batches of sql, use \';;\' to separate queries)";
            // 
            // tbSQLQuery
            // 
            this.tbSQLQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSQLQuery.Location = new System.Drawing.Point(6, 24);
            this.tbSQLQuery.Multiline = true;
            this.tbSQLQuery.Name = "tbSQLQuery";
            this.tbSQLQuery.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbSQLQuery.Size = new System.Drawing.Size(892, 302);
            this.tbSQLQuery.TabIndex = 6;
            this.tbSQLQuery.WordWrap = false;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(3, 68);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(0, 13);
            this.label39.TabIndex = 4;
            // 
            // btnStartSQLQuery
            // 
            this.btnStartSQLQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStartSQLQuery.Location = new System.Drawing.Point(6, 332);
            this.btnStartSQLQuery.Name = "btnStartSQLQuery";
            this.btnStartSQLQuery.Size = new System.Drawing.Size(75, 23);
            this.btnStartSQLQuery.TabIndex = 3;
            this.btnStartSQLQuery.Text = "Start";
            this.btnStartSQLQuery.UseVisualStyleBackColor = true;
            this.btnStartSQLQuery.Click += new System.EventHandler(this.btnStartSQLQuery_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(3, 13);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(0, 13);
            this.label32.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(972, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tbStatus
            // 
            this.tbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStatus.BackColor = System.Drawing.SystemColors.Info;
            this.tbStatus.Location = new System.Drawing.Point(12, 423);
            this.tbStatus.Multiline = true;
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbStatus.Size = new System.Drawing.Size(948, 155);
            this.tbStatus.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 584);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(972, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // imageBandR
            // 
            this.imageBandR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBandR.Image = ((System.Drawing.Image)(resources.GetObject("imageBandR.Image")));
            this.imageBandR.Location = new System.Drawing.Point(927, 49);
            this.imageBandR.Name = "imageBandR";
            this.imageBandR.Size = new System.Drawing.Size(33, 45);
            this.imageBandR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imageBandR.TabIndex = 10;
            this.imageBandR.TabStop = false;
            // 
            // imageBandRwait
            // 
            this.imageBandRwait.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBandRwait.Image = ((System.Drawing.Image)(resources.GetObject("imageBandRwait.Image")));
            this.imageBandRwait.Location = new System.Drawing.Point(927, 49);
            this.imageBandRwait.Name = "imageBandRwait";
            this.imageBandRwait.Size = new System.Drawing.Size(33, 45);
            this.imageBandRwait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imageBandRwait.TabIndex = 11;
            this.imageBandRwait.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 606);
            this.Controls.Add(this.imageBandRwait);
            this.Controls.Add(this.imageBandR);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ExportDbQueryToExcel";
            this.tb1.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            this.tp1.PerformLayout();
            this.tp2.ResumeLayout(false);
            this.tp2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBandR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBandRwait)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tb1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.TabPage tp1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbDBServer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.PictureBox imageBandR;
        private System.Windows.Forms.PictureBox imageBandRwait;
        private System.Windows.Forms.TabPage tp2;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Button btnStartSQLQuery;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDBPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDBUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDBName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSQLQuery;
        private System.Windows.Forms.CheckBox cbExportMultiToSheets;
    }
}

