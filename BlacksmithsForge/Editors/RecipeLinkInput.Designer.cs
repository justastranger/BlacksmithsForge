namespace BlacksmithsForge.Editors
{
    partial class RecipeLinkInput
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
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.chanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.chanceLabel = new System.Windows.Forms.Label();
            this.additionalCheckBox = new System.Windows.Forms.CheckBox();
            this.toPathLabel = new System.Windows.Forms.Label();
            this.toPathTextBox = new System.Windows.Forms.TextBox();
            this.challengesDataGridView = new System.Windows.Forms.DataGridView();
            this.elementIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.challengeLevelColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.challengesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chanceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.challengesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(12, 9);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 15);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID";
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idTextBox.Location = new System.Drawing.Point(12, 27);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 23);
            this.idTextBox.TabIndex = 1;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // chanceNumericUpDown
            // 
            this.chanceNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chanceNumericUpDown.Location = new System.Drawing.Point(152, 27);
            this.chanceNumericUpDown.Name = "chanceNumericUpDown";
            this.chanceNumericUpDown.Size = new System.Drawing.Size(100, 23);
            this.chanceNumericUpDown.TabIndex = 2;
            this.chanceNumericUpDown.ValueChanged += new System.EventHandler(this.chanceNumericUpDown_ValueChanged);
            // 
            // chanceLabel
            // 
            this.chanceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chanceLabel.AutoSize = true;
            this.chanceLabel.Location = new System.Drawing.Point(152, 9);
            this.chanceLabel.Name = "chanceLabel";
            this.chanceLabel.Size = new System.Drawing.Size(47, 15);
            this.chanceLabel.TabIndex = 3;
            this.chanceLabel.Text = "Chance";
            // 
            // additionalCheckBox
            // 
            this.additionalCheckBox.AutoSize = true;
            this.additionalCheckBox.Location = new System.Drawing.Point(12, 56);
            this.additionalCheckBox.Name = "additionalCheckBox";
            this.additionalCheckBox.Size = new System.Drawing.Size(81, 19);
            this.additionalCheckBox.TabIndex = 4;
            this.additionalCheckBox.Text = "Additional";
            this.additionalCheckBox.UseVisualStyleBackColor = true;
            this.additionalCheckBox.CheckedChanged += new System.EventHandler(this.additionalCheckBox_CheckedChanged);
            // 
            // toPathLabel
            // 
            this.toPathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toPathLabel.AutoSize = true;
            this.toPathLabel.Location = new System.Drawing.Point(152, 53);
            this.toPathLabel.Name = "toPathLabel";
            this.toPathLabel.Size = new System.Drawing.Size(46, 15);
            this.toPathLabel.TabIndex = 5;
            this.toPathLabel.Text = "To Path";
            // 
            // toPathTextBox
            // 
            this.toPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toPathTextBox.Location = new System.Drawing.Point(152, 71);
            this.toPathTextBox.Name = "toPathTextBox";
            this.toPathTextBox.Size = new System.Drawing.Size(100, 23);
            this.toPathTextBox.TabIndex = 6;
            this.toPathTextBox.TextChanged += new System.EventHandler(this.toPathTextBox_TextChanged);
            // 
            // challengesDataGridView
            // 
            this.challengesDataGridView.AllowUserToResizeRows = false;
            this.challengesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.challengesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.challengesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.challengesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.elementIDColumn,
            this.challengeLevelColumn});
            this.challengesDataGridView.Location = new System.Drawing.Point(12, 100);
            this.challengesDataGridView.MultiSelect = false;
            this.challengesDataGridView.Name = "challengesDataGridView";
            this.challengesDataGridView.RowTemplate.Height = 25;
            this.challengesDataGridView.Size = new System.Drawing.Size(240, 151);
            this.challengesDataGridView.TabIndex = 7;
            this.challengesDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.challengesDataGridView_DefaultValuesNeeded);
            this.challengesDataGridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.challengesDataGridView_RowValidated);
            // 
            // elementIDColumn
            // 
            this.elementIDColumn.HeaderText = "Element ID";
            this.elementIDColumn.Name = "elementIDColumn";
            // 
            // challengeLevelColumn
            // 
            this.challengeLevelColumn.HeaderText = "Challenge Level";
            this.challengeLevelColumn.Items.AddRange(new object[] {
            "base",
            "advanced"});
            this.challengeLevelColumn.Name = "challengeLevelColumn";
            // 
            // challengesLabel
            // 
            this.challengesLabel.AutoSize = true;
            this.challengesLabel.Location = new System.Drawing.Point(12, 82);
            this.challengesLabel.Name = "challengesLabel";
            this.challengesLabel.Size = new System.Drawing.Size(65, 15);
            this.challengesLabel.TabIndex = 8;
            this.challengesLabel.Text = "Challenges";
            // 
            // RecipeLinkInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 263);
            this.Controls.Add(this.challengesLabel);
            this.Controls.Add(this.challengesDataGridView);
            this.Controls.Add(this.toPathTextBox);
            this.Controls.Add(this.toPathLabel);
            this.Controls.Add(this.additionalCheckBox);
            this.Controls.Add(this.chanceLabel);
            this.Controls.Add(this.chanceNumericUpDown);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Name = "RecipeLinkInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recipe Link Input";
            ((System.ComponentModel.ISupportInitialize)(this.chanceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.challengesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label idLabel;
        private TextBox idTextBox;
        private NumericUpDown chanceNumericUpDown;
        private Label chanceLabel;
        private CheckBox additionalCheckBox;
        private Label toPathLabel;
        private TextBox toPathTextBox;
        private DataGridView challengesDataGridView;
        private DataGridViewTextBoxColumn elementIDColumn;
        private DataGridViewComboBoxColumn challengeLevelColumn;
        private Label challengesLabel;
    }
}