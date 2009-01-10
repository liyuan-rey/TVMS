using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TVMS.SmartClient.Controls;

namespace TVMS.SmartClient
{

    public partial class MainForm : Form
    {
        private static readonly Dictionary<string, TvmsTypeInfo> nodeObjectMap = new Dictionary<string, TvmsTypeInfo>();

        public MainForm()
        {
            InitializeComponent();

            LoadObjectMapConfigration();
        }

        private void LoadObjectMapConfigration()
        {
            nodeObjectMap["NodeTenements"] = new TvmsTypeInfo("TVMS.SmartClient.Controls.TenementsListView", "");
            nodeObjectMap["NodeTenement"] = new TvmsTypeInfo("TVMS.SmartClient.Controls.QuartersListView", "");
            nodeObjectMap["NodeContracts"] = new TvmsTypeInfo("TVMS.SmartClient.Controls.ContractsListView", "");
            nodeObjectMap["NodeCustomers"] = new TvmsTypeInfo("TVMS.SmartClient.Controls.CustomersListView", "");
        }

        private void tvwWorkspace_AfterSelect(object sender, TreeViewEventArgs e)
        {
            pnlList.SuspendLayout();

            //
            foreach (Control ctrl in pnlList.Controls)
            {
                if (ctrl.Visible == true && ctrl is ListView)
                    ctrl.Visible = false;
            }

            lblNavagator.Text = "";

            //
            ListView lvw = GetTvmsListView(e.Node.Tag.ToString());
            if (lvw != null)
            {
                lvw.SuspendLayout();

                if (!pnlList.Controls.Contains(lvw))
                    pnlList.Controls.Add(lvw);
                
                lvw.Visible = true;
                lvw.ResumeLayout(true);

                lblNavagator.Text = e.Node.Name;

                ITvmsListView tlv = lvw as ITvmsListView;
                if (tlv != null)
                    tlv.RefreshList();
            }

            pnlList.ResumeLayout(true);
        }

        private ListView GetTvmsListView(string nodeName)
        {
            ListView lvw = null;

            TvmsTypeInfo tti = null;
            if (nodeObjectMap.TryGetValue(nodeName, out tti))
            {
                if (tti.listInstance == null)
                {
                    lvw = (ListView)System.Reflection.Assembly.LoadFile(Application.ExecutablePath).CreateInstance(tti.listTypeName);
                    if (lvw != null)
                    {
                        tti.listType = lvw.GetType();
                        tti.listInstance = lvw;
                    }
                }
                else
                    lvw = tti.listInstance;
            }

            return lvw;
        }
    }
}