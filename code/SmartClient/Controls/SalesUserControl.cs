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
    public partial class SalesUserControl : UserControl
    {
        public SalesUserControl()
        {
            InitializeComponent();
            Sale logic = new Sale();
            this.salesInfoBindingSource.DataSource = logic.GetSales();
        }
    }
}
