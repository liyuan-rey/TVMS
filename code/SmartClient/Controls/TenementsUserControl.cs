using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using TVMS.BLL;
using TVMS.Model;

namespace TVMS.SmartClient.Controls
{
    public partial class TenementsUserControl : UserControl
    {
        private IList<TenementInfo> deletedTenements = new List<TenementInfo>();

        public TenementsUserControl()
        {
            InitializeComponent();
            bindingNavigatorRefreshItem.PerformClick();
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            try
            {
                deletedTenements.Clear();
                tenementsInfoBindingSource.DataSource = new Tenement().GetTenements();
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据刷新失败。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tenementsInfoBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            TenementInfo info = new TenementInfo();
            info.IsNew = true;
            info.IsDirty = true;
            info.Initializing = false;
            info.TenementId = 0;
            info.Name = "<新建项目>";

            e.NewObject = info;
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            deletedTenements.Add((TenementInfo)e.Row.DataBoundItem);
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            IList<TenementInfo> data = (IList<TenementInfo>)tenementsInfoBindingSource.DataSource;

            foreach (TenementInfo info in data)
            {
                if (info.IsNew)
                    AddNewTenement(info);
                else if (info.IsDirty)
                    UpdateTenement(info);
            }

            foreach (TenementInfo info in deletedTenements)
            {
                if (!info.IsNew)
                    DeleteTenement(info);
            }

            deletedTenements.Clear();
        }

        private bool AddNewTenement(TenementInfo info)
        {
            try
            {
                Tenement logic = new Tenement();
                logic.Insert(info);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("新建项目失败。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return false;
        }

        private bool UpdateTenement(TenementInfo info)
        {
            try
            {
                Tenement logic = new Tenement();
                logic.Update(info);
                return true;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("数据更新失败。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return false;
        }

        private void DeleteTenement(TenementInfo info)
        {
            try
            {
                Tenement logic = new Tenement();
                logic.Delete(info.TenementId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据删除失败。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
