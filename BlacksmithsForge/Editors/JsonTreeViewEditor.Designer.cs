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
            this.okayButton = new System.Windows.Forms.Button();
            this.addEntryToDictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEntryToArrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.jsonTreeView.Size = new System.Drawing.Size(707, 397);
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
            this.addEntryToDictionaryToolStripMenuItem});
            this.treeViewContextMenuStrip.Name = "treeViewContextMenuStrip";
            this.treeViewContextMenuStrip.Size = new System.Drawing.Size(198, 92);
            // 
            // editPropertyNameToolStripMenuItem
            // 
            this.editPropertyNameToolStripMenuItem.Name = "editPropertyNameToolStripMenuItem";
            this.editPropertyNameToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.editPropertyNameToolStripMenuItem.Text = "Edit Property Name";
            this.editPropertyNameToolStripMenuItem.Click += new System.EventHandler(this.editPropertyNameToolStripMenuItem_Click);
            // 
            // okayButton
            // 
            this.okayButton.Location = new System.Drawing.Point(328, 415);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(75, 23);
            this.okayButton.TabIndex = 1;
            this.okayButton.Text = "Okay";
            this.okayButton.UseVisualStyleBackColor = true;
            this.okayButton.Click += new System.EventHandler(this.okayButton_Click);
            // 
            // addEntryToDictionaryToolStripMenuItem
            // 
            this.addEntryToDictionaryToolStripMenuItem.Name = "addEntryToDictionaryToolStripMenuItem";
            this.addEntryToDictionaryToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.addEntryToDictionaryToolStripMenuItem.Text = "Add Entry to Dictionary";
            this.addEntryToDictionaryToolStripMenuItem.Click += new System.EventHandler(this.addEntryToDictionaryToolStripMenuItem_Click);
            // 
            // addEntryToArrayToolStripMenuItem
            // 
            this.addEntryToArrayToolStripMenuItem.Name = "addEntryToArrayToolStripMenuItem";
            this.addEntryToArrayToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.addEntryToArrayToolStripMenuItem.Text = "Add Entry to Array";
            this.addEntryToArrayToolStripMenuItem.Click += new System.EventHandler(this.addEntryToArrayToolStripMenuItem_Click);
            // 
            // JsonTreeViewEditor
            // 
            this.AcceptButton = this.okayButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.Controls.Add(this.okayButton);
            this.Controls.Add(this.jsonTreeView);
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
    }
}