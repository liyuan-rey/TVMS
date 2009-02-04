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

namespace TVMS.SmartClient.Controls
{
    public partial class QuartersUserControl : UserControl
    {
        public QuartersUserControl()
        {
            InitializeComponent();

            this.dataContainerTDS.Quarters.TableNewRow += new DataTableNewRowEventHandler(Quarters_TableNewRow);
            this.dataContainerTDS.Quarters.QuartersRowDeleting += new DataContainerTDS.QuartersRowChangeEventHandler(Quarters_QuartersRowDeleting);

            bindingNavigatorRefreshItem.PerformClick();
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
                    MessageBox.Show("住宅信息保存时出现冲突，请刷新数据后重试。/r/n" + dbce.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    if (trans != null)
                    {
                        trans.Rollback();
                    }
                    MessageBox.Show("住宅信息保存失败。/r/n" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            try
            {
                this.quartersBindingSource.CancelEdit();
                this.salesBindingSource.CancelEdit();

                this.dataContainerTDS.Clear();

                this.dataContainerTDS.Merge(DataContainerTDS.GetQuarters());
            }
            catch (Exception ex)
            {
                MessageBox.Show("读取住宅信息失败。/r/n" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void quartersBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (quartersBindingSource.Current != null)
                {
                    int quarterId = ((DataContainerTDS.QuartersRow)((DataRowView)quartersBindingSource.Current).Row).QuartersId;

                    customersTableAdapter.FillByQuarterId(dataContainerTDS.Customers, quarterId);
                    employeesTableAdapter.FillByQuarterId(dataContainerTDS.Employees, quarterId);

                    tenementsBindingSource.DataSource = ((DataRowView)quartersBindingSource.Current).Row;
                    tenementsBindingSource.DataMember = "TVMS_TenementsRow";

                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("读取关联数据失败。/r/n" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
