using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;
using TVMS.DataService;
using TVMS.DataService.DataContainerTDSTableAdapters;

namespace TVMS.Controls
{
    public partial class QuartersUserControl : UserControl, ITvmsUserControl
    {
        public QuartersUserControl()
        {
            InitializeComponent();

            this.dataContainerTDS.Quarters.TableNewRow += new DataTableNewRowEventHandler(Quarters_TableNewRow);
            this.dataContainerTDS.Quarters.QuartersRowDeleting += new DataContainerTDS.QuartersRowChangeEventHandler(Quarters_QuartersRowDeleting);
        }

        void Quarters_QuartersRowDeleting(object sender, DataContainerTDS.QuartersRowChangeEvent e)
        {
            DataContainerTDS.SalesRow[] rows = e.Row.GetSalesRows();

            foreach (DataContainerTDS.SalesRow row in rows)
            {
                row.Delete();
            }
        }

        void Quarters_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            DataContainerTDS.SalesRow newSaleRow = dataContainerTDS.Sales.NewSalesRow();
            newSaleRow.TVMS_QuartersRow = (DataContainerTDS.QuartersRow)e.Row;
            dataContainerTDS.Sales.AddSalesRow(newSaleRow);
        }

        private void quartersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.quartersBindingSource.EndEdit();
            this.salesBindingSource.EndEdit();

            using (quartersTableAdapter.Connection)
            {
                OleDbTransaction trans = null;

                try
                {
                    if (quartersTableAdapter.Connection.State != ConnectionState.Open)
                    {
                        quartersTableAdapter.Connection.Open();
                    }
                    salesTableAdapter.Connection = quartersTableAdapter.Connection;

                    trans = quartersTableAdapter.Connection.BeginTransaction(IsolationLevel.ReadCommitted);

                    quartersTableAdapter.BeginTransaction(quartersTableAdapter.Connection, trans);
                    salesTableAdapter.BeginTransaction(salesTableAdapter.Connection, trans);

                    int numUpdated = 0;
                    numUpdated += salesTableAdapter.Update(dataContainerTDS.Sales.Select("", "", DataViewRowState.Deleted));
                    numUpdated += quartersTableAdapter.Update(dataContainerTDS.Quarters.Select("", "", DataViewRowState.Deleted));
                    numUpdated += quartersTableAdapter.Update(dataContainerTDS.Quarters.Select("", "", DataViewRowState.CurrentRows));
                    numUpdated += salesTableAdapter.Update(dataContainerTDS.Sales.Select("", "", DataViewRowState.CurrentRows));

                    trans.Commit();

                    salesBindingSource.ResetBindings(false);
                }
                catch (DBConcurrencyException dbce)
                {
                    if (trans != null)
                    {
                        trans.Rollback();
                    }
                    MessageBox.Show("住宅信息保存时出现冲突，请刷新数据后重试。\r\n" + dbce.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    if (trans != null)
                    {
                        trans.Rollback();
                    }
                    MessageBox.Show("住宅信息保存失败。\r\n" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    //--- Clean Up Code
                    if (quartersTableAdapter.Connection.State == ConnectionState.Open)
                    {
                        quartersTableAdapter.Connection.Close();
                        quartersTableAdapter.Connection = null;
                        salesTableAdapter.Connection = null;
                    }

                    trans = null;
                }

            }
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void quartersBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            this.Validate();
            this.quartersBindingSource.EndEdit();
            this.salesBindingSource.EndEdit();

            try
            {
                if (quartersBindingSource.Current != null)
                {
                    DataContainerTDS.QuartersRow row = (DataContainerTDS.QuartersRow)((DataRowView)quartersBindingSource.Current).Row;

                    customersTableAdapter.FillByQuarterId(dataContainerTDS.Customers, row.QuartersId);
                    employeesTableAdapter.FillByQuarterId(dataContainerTDS.Employees, row.QuartersId);

                    tenementsBindingSource.DataSource = row.TVMS_TenementsRow;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("读取关联数据失败。\r\n" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region ITvmsUserControl 成员

        public void RefreshData()
        {
            try
            {
                this.quartersBindingSource.CancelEdit();
                this.salesBindingSource.CancelEdit();

                this.dataContainerTDS.Clear();

                this.dataContainerTDS.Merge(DataContainerTDS.GetQuarters());
            }
            catch (Exception ex)
            {
                MessageBox.Show("读取住宅信息失败。\r\n" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion
    }
}
