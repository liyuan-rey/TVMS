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
    public partial class TenementsListView : ListView, ITvmsListView
    {
        public TenementsListView()
        {
            InitializeComponent();
        }

        public void RefreshList()
        {
            this.Items.Clear();

            Tenement ten = new Tenement();
            IList<TenementInfo> tens = ten.GetTenements();

            foreach (TenementInfo ti in tens)
            {
                ListViewItem lvi = new ListViewItem(new string[] { ti.TenementId.ToString(), ti.Name });
                lvi.Tag = ti;

                this.Items.Add(lvi);
            }
        }
    }
}
