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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Elements", System.Windows.Forms.HorizontalAlignment.Left);
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
            this.fileTypeLabel = new System.Windows.Forms.Label();
            this.jsonTextEditorButton = new System.Windows.Forms.Button();
            this.toolStrip.SuspendLayout();
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
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.openFolderToolStripMenuItem.Text = "Open Folder";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
            // 
            // editSynopsisToolStripMenuItem
            // 
            this.editSynopsisToolStripMenuItem.Name = "editSynopsisToolStripMenuItem";
            this.editSynopsisToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.editSynopsisToolStripMenuItem.Text = "Edit Synopsis";
            this.editSynopsisToolStripMenuItem.Click += new System.EventHandler(this.editSynopsisToolStripMenuItem_Click);
            // 
            // saveModToolStripMenuItem
            // 
            this.saveModToolStripMenuItem.Name = "saveModToolStripMenuItem";
            this.saveModToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveModToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
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
            listViewGroup1.Header = "Elements";
            listViewGroup1.Name = "elementsListViewGroup";
            this.filesListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.filesListView.Location = new System.Drawing.Point(12, 28);
            this.filesListView.MultiSelect = false;
            this.filesListView.Name = "filesListView";
            this.filesListView.ShowGroups = false;
            this.filesListView.Size = new System.Drawing.Size(366, 410);
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
            this.entitiesListView.Size = new System.Drawing.Size(404, 331);
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
            // fileTypeLabel
            // 
            this.fileTypeLabel.AutoSize = true;
            this.fileTypeLabel.Location = new System.Drawing.Point(384, 28);
            this.fileTypeLabel.Name = "fileTypeLabel";
            this.fileTypeLabel.Size = new System.Drawing.Size(69, 15);
            this.fileTypeLabel.TabIndex = 3;
            this.fileTypeLabel.Text = "Not Loaded";
            // 
            // jsonTextEditorButton
            // 
            this.jsonTextEditorButton.Location = new System.Drawing.Point(384, 46);
            this.jsonTextEditorButton.Name = "jsonTextEditorButton";
            this.jsonTextEditorButton.Size = new System.Drawing.Size(75, 23);
            this.jsonTextEditorButton.TabIndex = 4;
            this.jsonTextEditorButton.Text = "Edit as Text";
            this.jsonTextEditorButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.jsonTextEditorButton);
            this.Controls.Add(this.fileTypeLabel);
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
        private Label fileTypeLabel;
        private Button jsonTextEditorButton;
    }
}