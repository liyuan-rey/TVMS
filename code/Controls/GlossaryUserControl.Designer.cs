namespace TVMS.Controls
{
    partial class GlossaryUserControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.categoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataContainerTDS = new TVMS.DataService.DataContainerTDS();
            this.panel1 = new System.Windows.Forms.Panel();
            this.categoryToolStrip = new System.Windows.Forms.ToolStrip();
            this.categoryToolStripAddNewButton = new System.Windows.Forms.ToolStripButton();
            this.categoryToolStripDeleteButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.categoryToolStripRefreshButton = new System.Windows.Forms.ToolStripButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.itemDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.itemToolStrip = new System.Windows.Forms.ToolStrip();
            this.itemToolStripAddNewButton = new System.Windows.Forms.ToolStripButton();
            this.itemToolStripDeleteButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.itemToolStripRefreshButton = new System.Windows.Forms.ToolStripButton();
            this.glossaryTableAdapter = new TVMS.DataService.DataContainerTDSTableAdapters.GlossaryTableAdapter();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataContainerTDS)).BeginInit();
            this.panel1.SuspendLayout();
            this.categoryToolStrip.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.itemToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(471, 296);
            this.splitContainer1.SplitterDistance = 160;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.categoryDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 270);
            this.panel2.TabIndex = 2;
            // 
            // categoryDataGridView
            // 
            this.categoryDataGridView.AllowUserToAddRows = false;
            this.categoryDataGridView.AllowUserToDeleteRows = false;
            this.categoryDataGridView.AutoGenerateColumns = false;
            this.categoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8});
            this.categoryDataGridView.DataSource = this.categoryBindingSource;
            this.categoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryDataGridView.Location = new System.Drawing.Point(0, 0);
            this.categoryDataGridView.Name = "categoryDataGridView";
            this.categoryDataGridView.RowHeadersVisible = false;
            this.categoryDataGridView.RowTemplate.Height = 23;
            this.categoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categoryDataGridView.Size = new System.Drawing.Size(160, 270);
            this.categoryDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TermId";
            this.dataGridViewTextBoxColumn5.HeaderText = "TermId";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TermValue";
            this.dataGridViewTextBoxColumn7.HeaderText = "类别值";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TermKey";
            this.dataGridViewTextBoxColumn6.HeaderText = "类别键";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ParentTermId";
            this.dataGridViewTextBoxColumn8.HeaderText = "ParentTermId";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Glossary";
            this.categoryBindingSource.DataSource = this.dataContainerTDS;
            this.categoryBindingSource.Filter = "ParentTermId is null";
            this.categoryBindingSource.Sort = "TermId";
            this.categoryBindingSource.CurrentChanged += new System.EventHandler(this.categoryBindingSource_CurrentChanged);
            // 
            // dataContainerTDS
            // 
            this.dataContainerTDS.DataSetName = "DataContainerTDS";
            this.dataContainerTDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.categoryToolStrip);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 26);
            this.panel1.TabIndex = 1;
            // 
            // categoryToolStrip
            // 
            this.categoryToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryToolStripAddNewButton,
            this.categoryToolStripDeleteButton,
            this.toolStripSeparator1,
            this.categoryToolStripRefreshButton});
            this.categoryToolStrip.Location = new System.Drawing.Point(0, 0);
            this.categoryToolStrip.Name = "categoryToolStrip";
            this.categoryToolStrip.Size = new System.Drawing.Size(160, 25);
            this.categoryToolStrip.TabIndex = 0;
            this.categoryToolStrip.Text = "toolStrip1";
            // 
            // categoryToolStripAddNewButton
            // 
            this.categoryToolStripAddNewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.categoryToolStripAddNewButton.Image = global::TVMS.Properties.Resources.bindingNavigatorAddNewItem_Image;
            this.categoryToolStripAddNewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.categoryToolStripAddNewButton.Name = "categoryToolStripAddNewButton";
            this.categoryToolStripAddNewButton.Size = new System.Drawing.Size(23, 22);
            this.categoryToolStripAddNewButton.Text = "新建类别";
            this.categoryToolStripAddNewButton.Click += new System.EventHandler(this.categoryToolStripAddNewButton_Click);
            // 
            // categoryToolStripDeleteButton
            // 
            this.categoryToolStripDeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.categoryToolStripDeleteButton.Image = global::TVMS.Properties.Resources.bindingNavigatorDeleteItem_Image;
            this.categoryToolStripDeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.categoryToolStripDeleteButton.Name = "categoryToolStripDeleteButton";
            this.categoryToolStripDeleteButton.Size = new System.Drawing.Size(23, 22);
            this.categoryToolStripDeleteButton.Text = "删除类别";
            this.categoryToolStripDeleteButton.ToolTipText = "删除类别";
            this.categoryToolStripDeleteButton.Click += new System.EventHandler(this.categoryToolStripDeleteButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // categoryToolStripRefreshButton
            // 
            this.categoryToolStripRefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.categoryToolStripRefreshButton.Image = global::TVMS.Properties.Resources.bindingNavigatorRefreshItem_Image;
            this.categoryToolStripRefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.categoryToolStripRefreshButton.Name = "categoryToolStripRefreshButton";
            this.categoryToolStripRefreshButton.Size = new System.Drawing.Size(23, 22);
            this.categoryToolStripRefreshButton.Text = "全部刷新";
            this.categoryToolStripRefreshButton.Click += new System.EventHandler(this.categoryToolStripRefreshButton_Click);
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.itemDataGridView);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 26);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(307, 270);
            this.panel4.TabIndex = 2;
            // 
            // itemDataGridView
            // 
            this.itemDataGridView.AllowUserToAddRows = false;
            this.itemDataGridView.AllowUserToDeleteRows = false;
            this.itemDataGridView.AutoGenerateColumns = false;
            this.itemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.itemDataGridView.DataSource = this.itemBindingSource;
            this.itemDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemDataGridView.Location = new System.Drawing.Point(0, 0);
            this.itemDataGridView.Name = "itemDataGridView";
            this.itemDataGridView.RowHeadersVisible = false;
            this.itemDataGridView.RowTemplate.Height = 23;
            this.itemDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemDataGridView.Size = new System.Drawing.Size(307, 270);
            this.itemDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TermId";
            this.dataGridViewTextBoxColumn1.HeaderText = "编号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TermKey";
            this.dataGridViewTextBoxColumn2.HeaderText = "键";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TermValue";
            this.dataGridViewTextBoxColumn3.HeaderText = "值";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ParentTermId";
            this.dataGridViewTextBoxColumn4.HeaderText = "父编号";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 60;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Glossary";
            this.itemBindingSource.DataSource = this.dataContainerTDS;
            this.itemBindingSource.Filter = "ParentTermId = 0";
            this.itemBindingSource.Sort = "TermKey";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.itemToolStrip);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(307, 26);
            this.panel3.TabIndex = 1;
            // 
            // itemToolStrip
            // 
            this.itemToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemToolStripAddNewButton,
            this.itemToolStripDeleteButton,
            this.toolStripSeparator2,
            this.itemToolStripRefreshButton});
            this.itemToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.itemToolStrip.Location = new System.Drawing.Point(0, 0);
            this.itemToolStrip.Name = "itemToolStrip";
            this.itemToolStrip.Size = new System.Drawing.Size(307, 25);
            this.itemToolStrip.TabIndex = 0;
            this.itemToolStrip.Text = "toolStrip2";
            // 
            // itemToolStripAddNewButton
            // 
            this.itemToolStripAddNewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.itemToolStripAddNewButton.Image = global::TVMS.Properties.Resources.bindingNavigatorAddNewItem_Image;
            this.itemToolStripAddNewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.itemToolStripAddNewButton.Name = "itemToolStripAddNewButton";
            this.itemToolStripAddNewButton.Size = new System.Drawing.Size(23, 22);
            this.itemToolStripAddNewButton.Text = "新建条目";
            this.itemToolStripAddNewButton.Click += new System.EventHandler(this.itemToolStripAddNewButton_Click);
            // 
            // itemToolStripDeleteButton
            // 
            this.itemToolStripDeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.itemToolStripDeleteButton.Image = global::TVMS.Properties.Resources.bindingNavigatorDeleteItem_Image;
            this.itemToolStripDeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.itemToolStripDeleteButton.Name = "itemToolStripDeleteButton";
            this.itemToolStripDeleteButton.Size = new System.Drawing.Size(23, 22);
            this.itemToolStripDeleteButton.Text = "删除条目";
            this.itemToolStripDeleteButton.Click += new System.EventHandler(this.itemToolStripDeleteButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // itemToolStripRefreshButton
            // 
            this.itemToolStripRefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.itemToolStripRefreshButton.Image = global::TVMS.Properties.Resources.bindingNavigatorRefreshItem_Image;
            this.itemToolStripRefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.itemToolStripRefreshButton.Name = "itemToolStripRefreshButton";
            this.itemToolStripRefreshButton.Size = new System.Drawing.Size(23, 22);
            this.itemToolStripRefreshButton.Text = "重置";
            this.itemToolStripRefreshButton.Click += new System.EventHandler(this.itemToolStripRefreshButton_Click);
            // 
            // glossaryTableAdapter
            // 
            this.glossaryTableAdapter.ClearBeforeFill = true;
            // 
            // GlossaryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "GlossaryUserControl";
            this.Size = new System.Drawing.Size(471, 296);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataContainerTDS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.categoryToolStrip.ResumeLayout(false);
            this.categoryToolStrip.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.itemToolStrip.ResumeLayout(false);
            this.itemToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip categoryToolStrip;
        private System.Windows.Forms.ToolStripButton categoryToolStripAddNewButton;
        private System.Windows.Forms.ToolStripButton categoryToolStripDeleteButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStrip itemToolStrip;
        private System.Windows.Forms.ToolStripButton itemToolStripAddNewButton;
        private System.Windows.Forms.ToolStripButton itemToolStripDeleteButton;
        private TVMS.DataService.DataContainerTDS dataContainerTDS;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private TVMS.DataService.DataContainerTDSTableAdapters.GlossaryTableAdapter glossaryTableAdapter;
        private System.Windows.Forms.DataGridView itemDataGridView;
        private System.Windows.Forms.DataGridView categoryDataGridView;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton categoryToolStripRefreshButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton itemToolStripRefreshButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
