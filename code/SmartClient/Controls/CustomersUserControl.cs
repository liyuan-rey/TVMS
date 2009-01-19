using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using TVMS.BLL;

namespace TVMS.SmartClient.Controls
{
    public partial class CustomersUserControl : UserControl
    {
        public CustomersUserControl()
        {
            InitializeComponent();
            Customer logic = new Customer();
            this.customersInfoBindingSource.DataSource = logic.GetCustomers();
        }
    }
}
