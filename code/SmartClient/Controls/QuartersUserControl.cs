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
    public partial class QuartersUserControl : UserControl
    {
        public QuartersUserControl()
        {
            InitializeComponent();
            Quarters logic = new Quarters();
            this.quartersInfoBindingSource.DataSource = logic.GetQuarters();
        }
    }
}
