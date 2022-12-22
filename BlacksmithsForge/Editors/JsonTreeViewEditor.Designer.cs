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
            this.jsonTreeView = new System.Windows.Forms.TreeView();
            this.okayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // jsonTreeView
            // 
            this.jsonTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jsonTreeView.Location = new System.Drawing.Point(12, 12);
            this.jsonTreeView.Name = "jsonTreeView";
            this.jsonTreeView.Size = new System.Drawing.Size(707, 397);
            this.jsonTreeView.TabIndex = 0;
            this.jsonTreeView.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.jsonTreeView_AfterLabelEdit);
            this.jsonTreeView.Click += new System.EventHandler(this.jsonTreeView_Click);
            this.jsonTreeView.DoubleClick += new System.EventHandler(this.jsonTreeView_DoubleClick);
            this.jsonTreeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.jsonTreeView_MouseDown);
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
            this.ResumeLayout(false);

        }

        #endregion

        private TreeView jsonTreeView;
        private Button okayButton;
    }
}