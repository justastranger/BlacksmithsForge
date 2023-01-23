namespace BlacksmithsForge.Editors
{
    partial class JsonTreeViewEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.jsonTreeView = new System.Windows.Forms.TreeView();
            this.treeViewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editPropertyNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEntryToArrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEntryToDictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPropertyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePropertyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEntityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recipeLinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sphereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.okayButton = new System.Windows.Forms.Button();
            this.xTriggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeViewContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // jsonTreeView
            // 
            this.jsonTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jsonTreeView.ContextMenuStrip = this.treeViewContextMenuStrip;
            this.jsonTreeView.Location = new System.Drawing.Point(12, 12);
            this.jsonTreeView.Name = "jsonTreeView";
            this.jsonTreeView.Size = new System.Drawing.Size(304, 249);
            this.jsonTreeView.TabIndex = 0;
            this.jsonTreeView.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.jsonTreeView_AfterLabelEdit);
            this.jsonTreeView.Click += new System.EventHandler(this.jsonTreeView_Click);
            this.jsonTreeView.DoubleClick += new System.EventHandler(this.jsonTreeView_DoubleClick);
            this.jsonTreeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.jsonTreeView_MouseDown);
            // 
            // treeViewContextMenuStrip
            // 
            this.treeViewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editPropertyNameToolStripMenuItem,
            this.addEntryToArrayToolStripMenuItem,
            this.addEntryToDictionaryToolStripMenuItem,
            this.addPropertyToolStripMenuItem,
            this.deletePropertyToolStripMenuItem,
            this.addEntityToolStripMenuItem});
            this.treeViewContextMenuStrip.Name = "treeViewContextMenuStrip";
            this.treeViewContextMenuStrip.Size = new System.Drawing.Size(198, 158);
            // 
            // editPropertyNameToolStripMenuItem
            // 
            this.editPropertyNameToolStripMenuItem.Name = "editPropertyNameToolStripMenuItem";
            this.editPropertyNameToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.editPropertyNameToolStripMenuItem.Text = "Edit Property Name";
            this.editPropertyNameToolStripMenuItem.Click += new System.EventHandler(this.editPropertyNameToolStripMenuItem_Click);
            // 
            // addEntryToArrayToolStripMenuItem
            // 
            this.addEntryToArrayToolStripMenuItem.Name = "addEntryToArrayToolStripMenuItem";
            this.addEntryToArrayToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.addEntryToArrayToolStripMenuItem.Text = "Add Entry to Array";
            this.addEntryToArrayToolStripMenuItem.Click += new System.EventHandler(this.addEntryToArrayToolStripMenuItem_Click);
            // 
            // addEntryToDictionaryToolStripMenuItem
            // 
            this.addEntryToDictionaryToolStripMenuItem.Name = "addEntryToDictionaryToolStripMenuItem";
            this.addEntryToDictionaryToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.addEntryToDictionaryToolStripMenuItem.Text = "Add Entry to Dictionary";
            this.addEntryToDictionaryToolStripMenuItem.Click += new System.EventHandler(this.addEntryToDictionaryToolStripMenuItem_Click);
            // 
            // addPropertyToolStripMenuItem
            // 
            this.addPropertyToolStripMenuItem.Name = "addPropertyToolStripMenuItem";
            this.addPropertyToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.addPropertyToolStripMenuItem.Text = "Add Property";
            this.addPropertyToolStripMenuItem.Click += new System.EventHandler(this.addPropertyToolStripMenuItem_Click);
            // 
            // deletePropertyToolStripMenuItem
            // 
            this.deletePropertyToolStripMenuItem.Name = "deletePropertyToolStripMenuItem";
            this.deletePropertyToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.deletePropertyToolStripMenuItem.Text = "Delete Property";
            this.deletePropertyToolStripMenuItem.Click += new System.EventHandler(this.deletePropertyToolStripMenuItem_Click);
            // 
            // addEntityToolStripMenuItem
            // 
            this.addEntityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recipeLinkToolStripMenuItem,
            this.sphereToolStripMenuItem,
            this.xTriggerToolStripMenuItem,
            this.dictionaryToolStripMenuItem});
            this.addEntityToolStripMenuItem.Name = "addEntityToolStripMenuItem";
            this.addEntityToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.addEntityToolStripMenuItem.Text = "Add Entity";
            // 
            // recipeLinkToolStripMenuItem
            // 
            this.recipeLinkToolStripMenuItem.Name = "recipeLinkToolStripMenuItem";
            this.recipeLinkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.recipeLinkToolStripMenuItem.Text = "Recipe Link";
            this.recipeLinkToolStripMenuItem.Click += new System.EventHandler(this.recipeLinkToolStripMenuItem_Click);
            // 
            // sphereToolStripMenuItem
            // 
            this.sphereToolStripMenuItem.Name = "sphereToolStripMenuItem";
            this.sphereToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sphereToolStripMenuItem.Text = "Sphere";
            this.sphereToolStripMenuItem.Click += new System.EventHandler(this.sphereToolStripMenuItem_Click);
            // 
            // dictionaryToolStripMenuItem
            // 
            this.dictionaryToolStripMenuItem.Name = "dictionaryToolStripMenuItem";
            this.dictionaryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dictionaryToolStripMenuItem.Text = "Dictionary";
            this.dictionaryToolStripMenuItem.Click += new System.EventHandler(this.dictionaryToolStripMenuItem_Click);
            // 
            // okayButton
            // 
            this.okayButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.okayButton.Location = new System.Drawing.Point(127, 267);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(75, 23);
            this.okayButton.TabIndex = 1;
            this.okayButton.Text = "Okay";
            this.okayButton.UseVisualStyleBackColor = true;
            this.okayButton.Click += new System.EventHandler(this.okayButton_Click);
            // 
            // xTriggerToolStripMenuItem
            // 
            this.xTriggerToolStripMenuItem.Name = "xTriggerToolStripMenuItem";
            this.xTriggerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xTriggerToolStripMenuItem.Text = "XTrigger";
            this.xTriggerToolStripMenuItem.Click += new System.EventHandler(this.xTriggerToolStripMenuItem_Click);
            // 
            // JsonTreeViewEditor
            // 
            this.AcceptButton = this.okayButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 302);
            this.Controls.Add(this.okayButton);
            this.Controls.Add(this.jsonTreeView);
            this.MinimumSize = new System.Drawing.Size(344, 341);
            this.Name = "JsonTreeViewEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Json TreeView Editor";
            this.Load += new System.EventHandler(this.JsonTreeViewEditor_Load);
            this.treeViewContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TreeView jsonTreeView;
        private Button okayButton;
        private ContextMenuStrip treeViewContextMenuStrip;
        private ToolStripMenuItem editPropertyNameToolStripMenuItem;
        private ToolStripMenuItem addEntryToArrayToolStripMenuItem;
        private ToolStripMenuItem addEntryToDictionaryToolStripMenuItem;
        private ToolStripMenuItem addPropertyToolStripMenuItem;
        private ToolStripMenuItem deletePropertyToolStripMenuItem;
        private ToolStripMenuItem addEntityToolStripMenuItem;
        private ToolStripMenuItem recipeLinkToolStripMenuItem;
        private ToolStripMenuItem sphereToolStripMenuItem;
        private ToolStripMenuItem dictionaryToolStripMenuItem;
        private ToolStripMenuItem xTriggerToolStripMenuItem;
    }
}