using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using TVMS.DataService;
using TVMS.DataService.DataContainerTDSTableAdapters;

namespace TVMS.SmartClient.Controls
{
    public partial class CustomersUserControl : UserControl
    {
        public CustomersUserControl()
        {
            InitializeComponent();

            bindingNavigatorRefreshItem.PerformClick();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.customersBindingSource.EndEdit();
                this.customersTableAdapter.Update(this.dataContainerTDS.Customers);
            }
            catch (Exception ex)
            {
                MessageBox.Show("客户信息保存失败。/r/n" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.customersBindingSource.CancelEdit();

                this.dataContainerTDS.Clear();

                customersTableAdapter.Fill(dataContainerTDS.Customers);
            }
            catch (Exception ex)
            {
                MessageBox.Show("读取客户列表失败。/r/n" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void customersBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (customersBindingSource.Current != null)
                {
                    int customerId = ((DataContainerTDS.CustomersRow)((DataRowView)customersBindingSource.Current).Row).CustomerId;
                    quartersTableAdapter.FillByCustomerId(dataContainerTDS.Quarters, customerId);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("读取相关住宅信息失败。/r/n" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
