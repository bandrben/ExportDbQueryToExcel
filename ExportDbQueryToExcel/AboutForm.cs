using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExportDbQueryToExcel
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            tbAbout.Text = @" *** Welcome to ExportDbQueryToExcel ***

Created by Ben Steinhauser of B&R Business Solutions.

";

            tbAbout.AppendText(" ");

        }
    }
}
