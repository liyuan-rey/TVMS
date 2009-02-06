using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using TVMS.DataService;
using TVMS.DataService.DataContainerTDSTableAdapters;

namespace TVMS.Controls
{
    public partial class TenementsUserControl : UserControl, ITvmsUserControl
    {
        public TenementsUserControl()
        {
            InitializeComponent();
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tenementsBindingSource.EndEdit();
                this.tenementsTableAdapter.Update(this.dataContainerTDS.Tenements);
            }
            catch (Exception ex)
            {
                MessageBox.Show("项目信息保存失败。\r\n" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void tenementsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (tenementsBindingSource.Current != null)
                {
                    int tenementId = ((DataContainerTDS.TenementsRow)((DataRowView)tenementsBindingSource.Current).Row).TenementId;
                    quartersTableAdapter.FillByTenementId(dataContainerTDS.Quarters, tenementId);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("读取相关住宅信息失败。\r\n" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        #region ITvmsUserControl 成员

        public void RefreshData()
        {
            try
            {
                this.tenementsBindingSource.CancelEdit();

                this.dataContainerTDS.Clear();

                tenementsTableAdapter.Fill(dataContainerTDS.Tenements);
            }
            catch (Exception ex)
            {
                MessageBox.Show("读取项目列表失败。\r\n" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion
    }
}
