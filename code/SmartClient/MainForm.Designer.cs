﻿namespace TVMS.SmartClient
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("项目");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("客户");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("合同");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("住宅");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("销售单");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("欢迎使用", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("访问网站");
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlWorkspace = new System.Windows.Forms.Panel();
            this.tvwWorkspace = new System.Windows.Forms.TreeView();
            this.pnlCaption = new System.Windows.Forms.Panel();
            this.lblCaption = new System.Windows.Forms.Label();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.系统SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tenementInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlWorkspace.SuspendLayout();
            this.pnlCaption.SuspendLayout();
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tenementInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.ssMain);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Padding = new System.Windows.Forms.Padding(7);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(585, 375);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(585, 421);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.mnuMain);
            // 
            // ssMain
            // 
            this.ssMain.Dock = System.Windows.Forms.DockStyle.None;
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.ssMain.Location = new System.Drawing.Point(0, 0);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(585, 22);
            this.ssMain.TabIndex = 0;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(29, 17);
            this.toolStripStatusLabel1.Text = "就绪";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(7, 7);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlWorkspace);
            this.splitContainer1.Panel1.Controls.Add(this.pnlCaption);
            this.splitContainer1.Size = new System.Drawing.Size(571, 361);
            this.splitContainer1.SplitterDistance = 161;
            this.splitContainer1.TabIndex = 0;
            // 
            // pnlWorkspace
            // 
            this.pnlWorkspace.Controls.Add(this.tvwWorkspace);
            this.pnlWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWorkspace.Location = new System.Drawing.Point(0, 25);
            this.pnlWorkspace.Name = "pnlWorkspace";
            this.pnlWorkspace.Size = new System.Drawing.Size(161, 336);
            this.pnlWorkspace.TabIndex = 3;
            // 
            // tvwWorkspace
            // 
            this.tvwWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwWorkspace.FullRowSelect = true;
            this.tvwWorkspace.HideSelection = false;
            this.tvwWorkspace.Location = new System.Drawing.Point(0, 0);
            this.tvwWorkspace.Name = "tvwWorkspace";
            treeNode1.Name = "NodeTenements";
            treeNode1.Tag = "";
            treeNode1.Text = "项目";
            treeNode1.ToolTipText = "项目列表";
            treeNode2.Name = "NodeCustomers";
            treeNode2.Tag = "";
            treeNode2.Text = "客户";
            treeNode2.ToolTipText = "客户列表";
            treeNode3.Name = "NodeContracts";
            treeNode3.Tag = "";
            treeNode3.Text = "合同";
            treeNode3.ToolTipText = "合同列表";
            treeNode4.Name = "NodeQuarters";
            treeNode4.Text = "住宅";
            treeNode4.ToolTipText = "住宅列表";
            treeNode5.Name = "NodeSales";
            treeNode5.Text = "销售单";
            treeNode5.ToolTipText = "销售单列表";
            treeNode6.Name = "NodeWelcome";
            treeNode6.Tag = "";
            treeNode6.Text = "欢迎使用";
            treeNode7.Name = "NodeWeb";
            treeNode7.Tag = "";
            treeNode7.Text = "访问网站";
            this.tvwWorkspace.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            this.tvwWorkspace.ShowNodeToolTips = true;
            this.tvwWorkspace.Size = new System.Drawing.Size(161, 336);
            this.tvwWorkspace.TabIndex = 0;
            this.tvwWorkspace.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwWorkspace_AfterSelect);
            // 
            // pnlCaption
            // 
            this.pnlCaption.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlCaption.Controls.Add(this.lblCaption);
            this.pnlCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCaption.Location = new System.Drawing.Point(0, 0);
            this.pnlCaption.Name = "pnlCaption";
            this.pnlCaption.Size = new System.Drawing.Size(161, 25);
            this.pnlCaption.TabIndex = 2;
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblCaption.Location = new System.Drawing.Point(3, 5);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(61, 14);
            this.lblCaption.TabIndex = 1;
            this.lblCaption.Text = "TVMS 1.0";
            // 
            // mnuMain
            // 
            this.mnuMain.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统SToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(585, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // 系统SToolStripMenuItem
            // 
            this.系统SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置PToolStripMenuItem,
            this.toolStripMenuItem1,
            this.退出XToolStripMenuItem});
            this.系统SToolStripMenuItem.Name = "系统SToolStripMenuItem";
            this.系统SToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.系统SToolStripMenuItem.Text = "系统(&S)";
            // 
            // 设置PToolStripMenuItem
            // 
            this.设置PToolStripMenuItem.Name = "设置PToolStripMenuItem";
            this.设置PToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.设置PToolStripMenuItem.Text = "设置(&P)...";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(127, 6);
            // 
            // 退出XToolStripMenuItem
            // 
            this.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
            this.退出XToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.退出XToolStripMenuItem.Text = "退出(&X)";
            // 
            // tenementInfoBindingSource
            // 
            this.tenementInfoBindingSource.DataSource = typeof(TVMS.Model.TenementInfo);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 421);
            this.Controls.Add(this.toolStripContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnuMain;
            this.Name = "MainForm";
            this.Text = "房产销售管理系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.pnlWorkspace.ResumeLayout(false);
            this.pnlCaption.ResumeLayout(false);
            this.pnlCaption.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tenementInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem 系统SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置PToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 退出XToolStripMenuItem;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvwWorkspace;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Panel pnlWorkspace;
        private System.Windows.Forms.Panel pnlCaption;
        private System.Windows.Forms.BindingSource tenementInfoBindingSource;
    }
}

