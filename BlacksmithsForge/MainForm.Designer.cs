namespace BlacksmithsForge
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Elements", System.Windows.Forms.HorizontalAlignment.Left);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.fileToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSynopsisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.filesListView = new System.Windows.Forms.ListView();
            this.filenameColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.entitiesListView = new System.Windows.Forms.ListView();
            this.idColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.jsonTextEditorButton = new System.Windows.Forms.Button();
            this.jsonTreeViewEditorButton = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.entityTypeToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.entityCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.filenameToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.addEntityButton = new System.Windows.Forms.Button();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripDropDownButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(800, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "Tool Strip";
            // 
            // fileToolStripDropDownButton
            // 
            this.fileToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFolderToolStripMenuItem,
            this.editSynopsisToolStripMenuItem,
            this.saveModToolStripMenuItem});
            this.fileToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripDropDownButton.Image")));
            this.fileToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileToolStripDropDownButton.Name = "fileToolStripDropDownButton";
            this.fileToolStripDropDownButton.Size = new System.Drawing.Size(38, 22);
            this.fileToolStripDropDownButton.Text = "File";
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.openFolderToolStripMenuItem.Text = "Open Folder";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
            // 
            // editSynopsisToolStripMenuItem
            // 
            this.editSynopsisToolStripMenuItem.Name = "editSynopsisToolStripMenuItem";
            this.editSynopsisToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editSynopsisToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.editSynopsisToolStripMenuItem.Text = "Edit Synopsis";
            this.editSynopsisToolStripMenuItem.Click += new System.EventHandler(this.editSynopsisToolStripMenuItem_Click);
            // 
            // saveModToolStripMenuItem
            // 
            this.saveModToolStripMenuItem.Name = "saveModToolStripMenuItem";
            this.saveModToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveModToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.saveModToolStripMenuItem.Text = "Save Mod";
            this.saveModToolStripMenuItem.Click += new System.EventHandler(this.saveModToolStripMenuItem_Click);
            // 
            // filesListView
            // 
            this.filesListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.filesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.filenameColumnHeader});
            this.filesListView.FullRowSelect = true;
            listViewGroup2.Header = "Elements";
            listViewGroup2.Name = "elementsListViewGroup";
            this.filesListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2});
            this.filesListView.Location = new System.Drawing.Point(12, 28);
            this.filesListView.MultiSelect = false;
            this.filesListView.Name = "filesListView";
            this.filesListView.ShowGroups = false;
            this.filesListView.Size = new System.Drawing.Size(366, 397);
            this.filesListView.TabIndex = 1;
            this.filesListView.UseCompatibleStateImageBehavior = false;
            this.filesListView.View = System.Windows.Forms.View.Details;
            this.filesListView.DoubleClick += new System.EventHandler(this.filesListView_DoubleClick);
            // 
            // filenameColumnHeader
            // 
            this.filenameColumnHeader.Text = "File";
            this.filenameColumnHeader.Width = 350;
            // 
            // entitiesListView
            // 
            this.entitiesListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.entitiesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumnHeader});
            this.entitiesListView.FullRowSelect = true;
            this.entitiesListView.Location = new System.Drawing.Point(384, 107);
            this.entitiesListView.MultiSelect = false;
            this.entitiesListView.Name = "entitiesListView";
            this.entitiesListView.ShowGroups = false;
            this.entitiesListView.Size = new System.Drawing.Size(404, 318);
            this.entitiesListView.TabIndex = 2;
            this.entitiesListView.UseCompatibleStateImageBehavior = false;
            this.entitiesListView.View = System.Windows.Forms.View.Details;
            this.entitiesListView.DoubleClick += new System.EventHandler(this.entitiesListView_DoubleClick);
            // 
            // idColumnHeader
            // 
            this.idColumnHeader.Text = "Entity ID";
            this.idColumnHeader.Width = 400;
            // 
            // jsonTextEditorButton
            // 
            this.jsonTextEditorButton.Location = new System.Drawing.Point(384, 46);
            this.jsonTextEditorButton.Name = "jsonTextEditorButton";
            this.jsonTextEditorButton.Size = new System.Drawing.Size(100, 23);
            this.jsonTextEditorButton.TabIndex = 4;
            this.jsonTextEditorButton.Text = "Edit as Text";
            this.jsonTextEditorButton.UseVisualStyleBackColor = true;
            this.jsonTextEditorButton.Click += new System.EventHandler(this.jsonTextEditorButton_Click);
            // 
            // jsonTreeViewEditorButton
            // 
            this.jsonTreeViewEditorButton.Location = new System.Drawing.Point(384, 78);
            this.jsonTreeViewEditorButton.Name = "jsonTreeViewEditorButton";
            this.jsonTreeViewEditorButton.Size = new System.Drawing.Size(100, 23);
            this.jsonTreeViewEditorButton.TabIndex = 5;
            this.jsonTreeViewEditorButton.Text = "Edit as Tree";
            this.jsonTreeViewEditorButton.UseVisualStyleBackColor = true;
            this.jsonTreeViewEditorButton.Click += new System.EventHandler(this.jsonTreeViewEditorButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entityTypeToolStripStatusLabel,
            this.entityCountToolStripStatusLabel,
            this.filenameToolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 8;
            // 
            // entityTypeToolStripStatusLabel
            // 
            this.entityTypeToolStripStatusLabel.Name = "entityTypeToolStripStatusLabel";
            this.entityTypeToolStripStatusLabel.Size = new System.Drawing.Size(95, 17);
            this.entityTypeToolStripStatusLabel.Text = "File Not Selected";
            // 
            // entityCountToolStripStatusLabel
            // 
            this.entityCountToolStripStatusLabel.Name = "entityCountToolStripStatusLabel";
            this.entityCountToolStripStatusLabel.Size = new System.Drawing.Size(79, 17);
            this.entityCountToolStripStatusLabel.Text = "Entity Count: ";
            // 
            // filenameToolStripStatusLabel
            // 
            this.filenameToolStripStatusLabel.Name = "filenameToolStripStatusLabel";
            this.filenameToolStripStatusLabel.Size = new System.Drawing.Size(108, 17);
            this.filenameToolStripStatusLabel.Text = "Selected Filename: ";
            // 
            // addEntityButton
            // 
            this.addEntityButton.Location = new System.Drawing.Point(490, 46);
            this.addEntityButton.Name = "addEntityButton";
            this.addEntityButton.Size = new System.Drawing.Size(100, 23);
            this.addEntityButton.TabIndex = 9;
            this.addEntityButton.Text = "New Entity";
            this.addEntityButton.UseVisualStyleBackColor = true;
            this.addEntityButton.Click += new System.EventHandler(this.addEntityButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addEntityButton);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.jsonTreeViewEditorButton);
            this.Controls.Add(this.jsonTextEditorButton);
            this.Controls.Add(this.entitiesListView);
            this.Controls.Add(this.filesListView);
            this.Controls.Add(this.toolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blacksmith\'s Forge";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip;
        private ToolStripDropDownButton fileToolStripDropDownButton;
        private ToolStripMenuItem openFolderToolStripMenuItem;
        private ToolStripMenuItem editSynopsisToolStripMenuItem;
        private ToolStripMenuItem saveModToolStripMenuItem;
        private FolderBrowserDialog folderBrowserDialog;
        private ListView filesListView;
        private ColumnHeader filenameColumnHeader;
        private ListView entitiesListView;
        private ColumnHeader idColumnHeader;
        private Button jsonTextEditorButton;
        private Button jsonTreeViewEditorButton;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel entityTypeToolStripStatusLabel;
        private ToolStripStatusLabel entityCountToolStripStatusLabel;
        private ToolStripStatusLabel filenameToolStripStatusLabel;
        private Button addEntityButton;
    }
}