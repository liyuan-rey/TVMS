﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

        }
    }
}