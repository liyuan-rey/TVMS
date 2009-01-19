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
    public partial class TenementsUserControl : UserControl
    {
        public TenementsUserControl()
        {
            InitializeComponent();
            Tenement logic = new Tenement();
            this.tenementsInfoBindingSource.DataSource = logic.GetTenements();
        }
    }
}
