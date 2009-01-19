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
    public partial class ContractsUserControl : UserControl
    {
        public ContractsUserControl()
        {
            InitializeComponent();
            Contract logic = new Contract();
            this.contractsInfoBindingSource.DataSource = logic.GetContracts();
        }
    }
}
