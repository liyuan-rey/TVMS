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
    public partial class CustomersListView : ListView, ITvmsListView
    {
        public CustomersListView()
        {
            InitializeComponent();
        }

        public void RefreshList()
        {
            this.Items.Clear();

            Customer cus = new Customer();
            IList<CustomerInfo> cuss = cus.GetCustomers();

            foreach (CustomerInfo ci in cuss)
            {
                ListViewItem lvi = new ListViewItem(new string[] { ci.CustomerId.ToString(), ci.Name, ci.Address, ci.Tel });
                lvi.Tag = ci;

                this.Items.Add(lvi);
            }
        }

        public void RefreshList(int parentId)
        {
            throw new ApplicationException("The method or operation is not implemented.");
        }
    }
}
