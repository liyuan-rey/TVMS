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
    public partial class ContractsListView : ListView, ITvmsListView
    {
        public ContractsListView()
        {
            InitializeComponent();
        }

        public void RefreshList()
        {
            this.Items.Clear();

            Contract con = new Contract();
            IList<ContractInfo> cons = con.GetContracts();

            foreach (ContractInfo ci in cons)
            {
                ListViewItem lvi = new ListViewItem(new string[] { ci.ContractId.ToString(), ci.Sn, ci.ContractType.ToString(), ci.SigningDate.ToLongDateString() });
                lvi.Tag = ci;

                this.Items.Add(lvi);
            }
        }
    }
}
