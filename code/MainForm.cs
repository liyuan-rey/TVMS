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
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadObjectMapConfigration();

            TreeNode node = tvwWorkspace.Nodes["NodeWelcome"];
            node.Expand();
        }

        //private void BuildTenementsTree()
        //{
        //    pnlWorkspace.SuspendLayout();
        //    tvwWorkspace.SuspendLayout();

        //    TreeNode tnTenements = tvwWorkspace.Nodes["NodeTenements"];
        //    tnTenements.Collapse();
        //    tnTenements.Nodes.Clear();

        //    IList<TenementInfo> tens = new TVMS.BLL.Tenement().GetTenements();
        //    foreach (TenementInfo ten in tens)
        //    {
        //        TreeNode node = new TreeNode();

        //        node.Name = "NodeTenement";
        //        node.Text = ten.Name;
        //        node.ToolTipText = ten.Name + "的住宅列表";
        //        node.Tag = ten;

        //        tnTenements.Nodes.Add(node);
        //    }

        //    if (tnTenements.Nodes.Count > 0)
        //        tnTenements.Expand();

        //    tvwWorkspace.ResumeLayout(true);
        //    pnlWorkspace.ResumeLayout(true);
        //}

        private void LoadObjectMapConfigration()
        {
            nodeObjectMap["NodeTenements"] = new TvmsTypeInfo("TVMS.SmartClient.Controls.TenementsUserControl");
            nodeObjectMap["NodeQuarters"] = new TvmsTypeInfo("TVMS.SmartClient.Controls.QuartersUserControl");
            nodeObjectMap["NodeCustomers"] = new TvmsTypeInfo("TVMS.SmartClient.Controls.CustomersUserControl");
            nodeObjectMap["NodeEmployees"] = new TvmsTypeInfo("TVMS.SmartClient.Controls.EmployeesUserControl");
            nodeObjectMap["NodeSales"] = new TvmsTypeInfo("TVMS.SmartClient.Controls.SalesUserControl");
        }

        private void tvwWorkspace_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!nodeObjectMap.ContainsKey(e.Node.Name))
                return;

            Panel parentPanel = splitContainer1.Panel2;

            foreach (Control ctrl in parentPanel.Controls)
            {
                if (ctrl.Visible == true && ctrl is UserControl)
                {
                    ctrl.Visible = false;
                    ctrl.Dock = DockStyle.None;
                }
            }

            //
            UserControl uc = GetTvmsUserControl(e.Node.Name);
            if (uc != null)
            {
                if (!parentPanel.Controls.Contains(uc))
                    parentPanel.Controls.Add(uc);

                uc.Dock = DockStyle.Fill;
                uc.Visible = true;
            }
        }

        private UserControl GetTvmsUserControl(string nodeName)
        {
            UserControl uc = null;
            TvmsTypeInfo tti = null;

            try
            {
                if (nodeObjectMap.TryGetValue(nodeName, out tti))
                {
                    if (tti.instance == null)
                    {
                        uc = (UserControl)System.Reflection.Assembly.LoadFile(Application.ExecutablePath).CreateInstance(tti.typeName);
                        if (uc != null)
                            tti.instance = uc;
                    }
                    else
                        uc = tti.instance;
                }
            }
            catch (Exception ex)
            {
                StringBuilder str = new StringBuilder();
                str.Append("加载用户界面失败。\r\n");
                str.Append(ex.Message);
                str.Append("，");
                str.Append(tti.typeName);
               MessageBox.Show(str.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return uc;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm frm = new SettingsForm();
            frm.ShowDialog(this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}