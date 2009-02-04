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
            connStringTextBox.Text = Properties.Settings.Default.SQLConnectionString;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (0 != String.Compare(Properties.Settings.Default.SQLConnectionString, connStringTextBox.Text, true))
                {
                    using (OleDbConnection conn = new OleDbConnection(connStringTextBox.Text))
                    {
                        conn.Open();
                        conn.Close();
                    }

                    Properties.Settings.Default.SQLConnectionString = connStringTextBox.Text;
                    Properties.Settings.Default.Save();

                    MessageBox.Show("数据连接信息修改将在下次程序启动时生效。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("数据库连接字符串设置错误。\r\n" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Close();
        }

        private void glossaryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.glossaryBindingSource.EndEdit();
            this.glossaryTableAdapter.Update(this.dataContainerTDS.Glossary);

        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dataContainerTDS.Glossary”中。您可以根据需要移动或移除它。
            this.glossaryTableAdapter.Fill(this.dataContainerTDS.Glossary);

        }
    }
}