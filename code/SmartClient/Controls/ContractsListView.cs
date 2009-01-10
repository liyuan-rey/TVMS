using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

        }
    }
}
