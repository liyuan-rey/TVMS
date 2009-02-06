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
    public partial class EmployeesUserControl : UserControl, ITvmsUserControl
    {
        public EmployeesUserControl()
        {
            InitializeComponent();
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
	            this.Validate();
	            this.employeesBindingSource.EndEdit();
	            this.employeesTableAdapter.Update(this.dataContainerTDS.Employees);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("销售员信息保存失败。\r\n" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void employeesBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (employeesBindingSource.Current != null)
                {
                    int employeeId = ((DataContainerTDS.EmployeesRow)((DataRowView)employeesBindingSource.Current).Row).EmployeeId;
                    quartersTableAdapter.FillByEmployeeId(dataContainerTDS.Quarters, employeeId);
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
                this.employeesBindingSource.CancelEdit();

                this.dataContainerTDS.Clear();

                employeesTableAdapter.Fill(dataContainerTDS.Employees);
            }
            catch (Exception ex)
            {
                MessageBox.Show("读取销售员列表失败。\r\n" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion
    }
}
