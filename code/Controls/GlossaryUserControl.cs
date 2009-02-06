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
    public partial class GlossaryUserControl : UserControl, ITvmsUserControl
    {
        public GlossaryUserControl()
        {
            InitializeComponent();
        }

        public bool Save(bool showMessage)
        {
            try
            {
	            this.Validate();

	            itemBindingSource.EndEdit();
                categoryBindingSource.EndEdit();

	            glossaryTableAdapter.Update(dataContainerTDS.Glossary.Select("ParentTermId is not null", "", DataViewRowState.Deleted)); // delete child rows
                glossaryTableAdapter.Update(dataContainerTDS.Glossary.Select("ParentTermId is not null", "", DataViewRowState.CurrentRows)); // modify child rows
                glossaryTableAdapter.Update(dataContainerTDS.Glossary.Select("ParentTermId is null", "", DataViewRowState.CurrentRows)); // modify parent rows
                glossaryTableAdapter.Update(dataContainerTDS.Glossary.Select("ParentTermId is null", "", DataViewRowState.Deleted)); // delete parent rows

                return true;
            }
            catch (System.Exception ex)
            {
                if (showMessage)
                {
                    MessageBox.Show("保存字典数据失败。\r\n" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            return false;
        }

        private void categoryToolStripRefreshButton_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void itemToolStripRefreshButton_Click(object sender, EventArgs e)
        {
            itemBindingSource.ResetBindings(false);
        }

        private void categoryBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (categoryBindingSource.Current != null)
            {
                int parentId = ((DataContainerTDS.GlossaryRow)((DataRowView)categoryBindingSource.Current).Row).TermId;

                StringBuilder filter = new StringBuilder("ParentTermId = ");
                filter.Append(parentId);
                itemBindingSource.Filter = filter.ToString();
            }
        }

        private void categoryToolStripAddNewButton_Click(object sender, EventArgs e)
        {
            AddNewTerm(null);
        }

        private void itemToolStripAddNewButton_Click(object sender, EventArgs e)
        {
            if (categoryBindingSource.Current != null)
            {
                AddNewTerm(((DataContainerTDS.GlossaryRow)((DataRowView)categoryBindingSource.Current).Row).TermId);
            }
        }

        private void AddNewTerm(Nullable<int> parentId)
        {
            itemBindingSource.EndEdit();
            categoryBindingSource.EndEdit();

            DataContainerTDS.GlossaryRow newRow = dataContainerTDS.Glossary.NewGlossaryRow();
            if (parentId != null)
            {
                newRow.ParentTermId = (int)parentId;
            }

            dataContainerTDS.Glossary.AddGlossaryRow(newRow);
        }

        private void categoryToolStripDeleteButton_Click(object sender, EventArgs e)
        {
            DataContainerTDS.GlossaryRow[] categoryRowsToDelete = new DataContainerTDS.GlossaryRow[categoryDataGridView.SelectedRows.Count];
            int index = 0;
            foreach (DataGridViewRow view in categoryDataGridView.SelectedRows)
            {
                DataContainerTDS.GlossaryRow row = (DataContainerTDS.GlossaryRow)((DataRowView)view.DataBoundItem).Row;
                categoryRowsToDelete[index] = row;
                index++;
            }

            DeleteTerms(categoryRowsToDelete);
        }

        private void itemToolStripDeleteButton_Click(object sender, EventArgs e)
        {
            DataContainerTDS.GlossaryRow[] itemRowsToDelete = new DataContainerTDS.GlossaryRow[itemDataGridView.SelectedRows.Count];
            int index = 0;
            foreach (DataGridViewRow view in itemDataGridView.SelectedRows)
            {
                DataContainerTDS.GlossaryRow row = (DataContainerTDS.GlossaryRow)((DataRowView)view.DataBoundItem).Row;
                itemRowsToDelete[index] = row;
                index++;
            }

            DeleteTerms(itemRowsToDelete);
        }

        private void DeleteTerms(DataContainerTDS.GlossaryRow[] rowsToDelete)
        {
            if (rowsToDelete == null)
            {
                throw new ArgumentNullException("rowsToDelete");
            }

            itemBindingSource.EndEdit();
            categoryBindingSource.EndEdit();

            foreach (DataContainerTDS.GlossaryRow row in rowsToDelete)
            {
                DeleteTerms(row.GetGlossaryRows());
                row.Delete();
            }
        }

        #region ITvmsUserControl 成员

        public void RefreshData()
        {
            try
            {
                itemBindingSource.CancelEdit();
                categoryBindingSource.CancelEdit();

                dataContainerTDS.Clear();

                glossaryTableAdapter.Fill(dataContainerTDS.Glossary);
            }
            catch (Exception ex)
            {
                MessageBox.Show("读取字典列表失败。\r\n" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion
    }
}
