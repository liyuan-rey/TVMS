using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TVMS.SmartClient.Controls;
using TVMS.Model;

namespace TVMS.SmartClient
{

    public partial class MainForm : Form
    {
        private static readonly Dictionary<string, TvmsTypeInfo> nodeObjectMap = new Dictionary<string, TvmsTypeInfo>();

        public MainForm()
        {
            LoadObjectMapConfigration();

            InitializeComponent();

            //BuildTenementsTree();
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
            nodeObjectMap["NodeContracts"] = new TvmsTypeInfo("TVMS.SmartClient.Controls.ContractsUserControl");
            nodeObjectMap["NodeCustomers"] = new TvmsTypeInfo("TVMS.SmartClient.Controls.CustomersUserControl");
            nodeObjectMap["NodeQuarters"] = new TvmsTypeInfo("TVMS.SmartClient.Controls.QuartersUserControl");
            nodeObjectMap["NodeSales"] = new TvmsTypeInfo("TVMS.SmartClient.Controls.SalesUserControl"); ;
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
                //parentPanel.SuspendLayout();

                if (!parentPanel.Controls.Contains(uc))
                    parentPanel.Controls.Add(uc);

            //    ITvmsListView tlv = lvw as ITvmsListView;
            //    if (tlv != null)
            //    {
            //        switch (e.Node.Name)
            //        {
            //            case "NodeTenement": //HACK:
            //                tlv.RefreshList(((TenementInfo)e.Node.Tag).TenementId);
            //                break;
            //            default:
            //                tlv.RefreshList();
            //                break;
            //        }
            //    }

                uc.Dock = DockStyle.Fill;
                uc.Visible = true;
            }
        }

        private UserControl GetTvmsUserControl(string nodeName)
        {
            UserControl uc = null;

            try
            {
                TvmsTypeInfo tti = null;
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
                MessageBox.Show("加载用户界面失败。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return uc;
        }

        //private ListView GetTvmsListView(string nodeName)
        //{
        //    ListView lvw = null;

        //    TvmsTypeInfo tti = null;
        //    if (nodeObjectMap.TryGetValue(nodeName, out tti))
        //    {
        //        if (tti.listInstance == null)
        //        {
        //            lvw = (ListView)System.Reflection.Assembly.LoadFile(Application.ExecutablePath).CreateInstance(tti.listTypeName);
        //            if (lvw != null)
        //            {
        //                lvw.ItemSelectionChanged += this.TvmsListView_ItemSelectionChanged;

        //                tti.listType = lvw.GetType();
        //                tti.listInstance = lvw;
        //            }
        //        }
        //        else
        //            lvw = tti.listInstance;
        //    }

        //    return lvw;
        //}

        //private TabPage GetTvmsTabPage(string nodeName)
        //{
        //    TabPage page = null;

        //    TvmsTypeInfo tti = null;
        //    if (nodeObjectMap.TryGetValue(nodeName, out tti))
        //    {
        //        if (tti.pageInstance == null)
        //        {
        //            page = (TabPage)System.Reflection.Assembly.LoadFile(Application.ExecutablePath).CreateInstance(tti.pageTypeName);
        //            if (page != null)
        //            {
        //                tti.pageType = page.GetType();
        //                tti.pageInstance = page;
        //            }
        //        }
        //        else
        //            page = tti.pageInstance;
        //    }

        //    return page;
        //}

        //private void TvmsListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        //{
        //    if (tvwWorkspace.SelectedNode == null)
        //        return;

        //    tabDetail.SuspendLayout();

        //    tabDetail.TabPages.Clear();

        //    if (e.IsSelected == true)
        //    {
        //        tabDetail.TabPages.Clear();

        //        TabPage page = GetTvmsTabPage(tvwWorkspace.SelectedNode.Name);
        //        if (page != null)
        //        {
        //            page.SuspendLayout();

        //            tabDetail.TabPages.Add(page);

        //            ITvmsTabPage ttp = page as ITvmsTabPage;
        //            if (ttp != null)
        //            {
        //                //TODO:
        //            }

        //            page.ResumeLayout(true);
        //        }
        //    }

        //    tabDetail.ResumeLayout(true);
        //}

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}