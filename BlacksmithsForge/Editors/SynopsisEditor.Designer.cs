namespace BlacksmithsForge.Editors
{
    partial class SynopsisEditor
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.versionLabel = new System.Windows.Forms.Label();
            this.versionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.longDescriptionLabel = new System.Windows.Forms.Label();
            this.longDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.okayButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tagsListBox = new System.Windows.Forms.ListBox();
            this.addTagButton = new System.Windows.Forms.Button();
            this.removeTagButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 27);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(410, 23);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 15);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(12, 53);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(44, 15);
            this.authorLabel.TabIndex = 2;
            this.authorLabel.Text = "Author";
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(12, 71);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(410, 23);
            this.authorTextBox.TabIndex = 3;
            this.authorTextBox.TextChanged += new System.EventHandler(this.authorTextBox_TextChanged);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(12, 97);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(45, 15);
            this.versionLabel.TabIndex = 4;
            this.versionLabel.Text = "Version";
            // 
            // versionTextBox
            // 
            this.versionTextBox.Location = new System.Drawing.Point(12, 115);
            this.versionTextBox.Name = "versionTextBox";
            this.versionTextBox.Size = new System.Drawing.Size(410, 23);
            this.versionTextBox.TabIndex = 5;
            this.versionTextBox.TextChanged += new System.EventHandler(this.versionTextBox_TextChanged);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(12, 159);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(410, 65);
            this.descriptionTextBox.TabIndex = 6;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.descriptionTextBox_TextChanged);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(12, 141);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(98, 15);
            this.descriptionLabel.TabIndex = 7;
            this.descriptionLabel.Text = "Short Description";
            // 
            // longDescriptionLabel
            // 
            this.longDescriptionLabel.AutoSize = true;
            this.longDescriptionLabel.Location = new System.Drawing.Point(12, 227);
            this.longDescriptionLabel.Name = "longDescriptionLabel";
            this.longDescriptionLabel.Size = new System.Drawing.Size(97, 15);
            this.longDescriptionLabel.TabIndex = 8;
            this.longDescriptionLabel.Text = "Long Description";
            // 
            // longDescriptionTextBox
            // 
            this.longDescriptionTextBox.Location = new System.Drawing.Point(12, 245);
            this.longDescriptionTextBox.Multiline = true;
            this.longDescriptionTextBox.Name = "longDescriptionTextBox";
            this.longDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.longDescriptionTextBox.Size = new System.Drawing.Size(410, 114);
            this.longDescriptionTextBox.TabIndex = 9;
            this.longDescriptionTextBox.TextChanged += new System.EventHandler(this.longDescriptionTextBox_TextChanged);
            // 
            // okayButton
            // 
            this.okayButton.Location = new System.Drawing.Point(12, 540);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(75, 23);
            this.okayButton.TabIndex = 10;
            this.okayButton.Text = "Okay";
            this.okayButton.UseVisualStyleBackColor = true;
            this.okayButton.Click += new System.EventHandler(this.okayButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tags";
            // 
            // tagsListBox
            // 
            this.tagsListBox.FormattingEnabled = true;
            this.tagsListBox.ItemHeight = 15;
            this.tagsListBox.Location = new System.Drawing.Point(12, 380);
            this.tagsListBox.Name = "tagsListBox";
            this.tagsListBox.Size = new System.Drawing.Size(410, 79);
            this.tagsListBox.TabIndex = 14;
            // 
            // addTagButton
            // 
            this.addTagButton.Location = new System.Drawing.Point(12, 465);
            this.addTagButton.Name = "addTagButton";
            this.addTagButton.Size = new System.Drawing.Size(75, 23);
            this.addTagButton.TabIndex = 17;
            this.addTagButton.Text = "Add";
            this.addTagButton.UseVisualStyleBackColor = true;
            this.addTagButton.Click += new System.EventHandler(this.addTagButton_Click);
            // 
            // removeTagButton
            // 
            this.removeTagButton.Location = new System.Drawing.Point(347, 465);
            this.removeTagButton.Name = "removeTagButton";
            this.removeTagButton.Size = new System.Drawing.Size(75, 23);
            this.removeTagButton.TabIndex = 18;
            this.removeTagButton.Text = "Remove";
            this.removeTagButton.UseVisualStyleBackColor = true;
            this.removeTagButton.Click += new System.EventHandler(this.removeTagButton_Click);
            // 
            // SynopsisEditor
            // 
            this.AcceptButton = this.okayButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 575);
            this.Controls.Add(this.removeTagButton);
            this.Controls.Add(this.addTagButton);
            this.Controls.Add(this.tagsListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okayButton);
            this.Controls.Add(this.longDescriptionTextBox);
            this.Controls.Add(this.longDescriptionLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.versionTextBox);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Name = "SynopsisEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Synopsis Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nameTextBox;
        private Label nameLabel;
        private Label authorLabel;
        private TextBox authorTextBox;
        private Label versionLabel;
        private TextBox versionTextBox;
        private TextBox descriptionTextBox;
        private Label descriptionLabel;
        private Label longDescriptionLabel;
        private TextBox longDescriptionTextBox;
        private Button okayButton;
        private Label label1;
        private ListBox tagsListBox;
        private Button addTagButton;
        private Button removeTagButton;
    }
}