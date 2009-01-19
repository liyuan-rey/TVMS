using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TVMS.BLL;
using TVMS.Model;

namespace TVMS.SmartClient.Controls
{
    public partial class QuartersListView : ListView, ITvmsListView
    {
        public QuartersListView()
        {
            InitializeComponent();
        }

        public void RefreshList()
        {
            throw new ApplicationException("The method or operation is not implemented.");
        }

        public void RefreshList(int parentId)
        {
            this.Items.Clear();

            Quarters q = new Quarters();
            IList<QuartersInfo> qis = q.GetQuartersByTenement(parentId);

            foreach (QuartersInfo qi in qis)
            {
                ListViewItem lvi = new ListViewItem(new string[] { qi.QuartersId.ToString(), qi.Model.ToString(), qi.BuiltUpArea.ToString(), qi.MarketPrice.ToString(), qi.Doorplate, qi.Property.ToString(), qi.Code, qi.Quantity.ToString() });
                lvi.Tag = qi;

                this.Items.Add(lvi);
            }
        }
    }
}
