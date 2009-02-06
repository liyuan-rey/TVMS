using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TVMS.Controls
{
    public partial class SalesUserControl : UserControl, ITvmsUserControl
    {
        public SalesUserControl()
        {
            InitializeComponent();
        }

        private void salesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
	            this.Validate();
	            this.salesBindingSource.EndEdit();
	            this.salesTableAdapter.Update(this.dataContainerTDS.Sales);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("销售单信息保存失败。\r\n" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void salesBindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void salesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        #region ITvmsUserControl 成员

        public void RefreshData()
        {
            try
            {
                this.salesBindingSource.CancelEdit();

                this.dataContainerTDS.Clear();

                salesTableAdapter.Fill(dataContainerTDS.Sales);
            }
            catch (Exception ex)
            {
                MessageBox.Show("读取销售单列表失败。\r\n" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion
    }
}
