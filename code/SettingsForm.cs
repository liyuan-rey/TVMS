using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TVMS
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // save glossary data
            bool bSuccess = glossaryUserControl.Save(true);
            
            if (bSuccess)
                this.Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            glossaryUserControl.RefreshData();
        }
    }
}