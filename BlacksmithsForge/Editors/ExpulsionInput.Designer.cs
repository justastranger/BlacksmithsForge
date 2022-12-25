namespace BlacksmithsForge.Editors
{
    partial class ExpulsionInput
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
            this.limitLabel = new System.Windows.Forms.Label();
            this.limitNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.filterDataGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toPathLabel = new System.Windows.Forms.Label();
            this.toPathTextBox = new System.Windows.Forms.TextBox();
            this.filterLabel = new System.Windows.Forms.Label();
            this.okayButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.limitNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // limitLabel
            // 
            this.limitLabel.AutoSize = true;
            this.limitLabel.Location = new System.Drawing.Point(12, 37);
            this.limitLabel.Name = "limitLabel";
            this.limitLabel.Size = new System.Drawing.Size(62, 15);
            this.limitLabel.TabIndex = 0;
            this.limitLabel.Text = "Total Limit";
            // 
            // limitNumericUpDown
            // 
            this.limitNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.limitNumericUpDown.Location = new System.Drawing.Point(80, 35);
            this.limitNumericUpDown.Name = "limitNumericUpDown";
            this.limitNumericUpDown.Size = new System.Drawing.Size(84, 23);
            this.limitNumericUpDown.TabIndex = 1;
            this.limitNumericUpDown.ValueChanged += new System.EventHandler(this.limitNumericUpDown_ValueChanged);
            // 
            // filterDataGridView
            // 
            this.filterDataGridView.AllowUserToResizeColumns = false;
            this.filterDataGridView.AllowUserToResizeRows = false;
            this.filterDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.filterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.limitColumn});
            this.filterDataGridView.Location = new System.Drawing.Point(12, 64);
            this.filterDataGridView.MultiSelect = false;
            this.filterDataGridView.Name = "filterDataGridView";
            this.filterDataGridView.RowTemplate.Height = 25;
            this.filterDataGridView.Size = new System.Drawing.Size(315, 179);
            this.filterDataGridView.TabIndex = 2;
            this.filterDataGridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.filterDataGridView_RowValidated);
            this.filterDataGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.filterDataGridView_UserDeletedRow);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "Element ID";
            this.idColumn.Name = "idColumn";
            // 
            // limitColumn
            // 
            this.limitColumn.HeaderText = "Limit";
            this.limitColumn.Name = "limitColumn";
            // 
            // toPathLabel
            // 
            this.toPathLabel.AutoSize = true;
            this.toPathLabel.Location = new System.Drawing.Point(12, 9);
            this.toPathLabel.Name = "toPathLabel";
            this.toPathLabel.Size = new System.Drawing.Size(46, 15);
            this.toPathLabel.TabIndex = 3;
            this.toPathLabel.Text = "To Path";
            // 
            // toPathTextBox
            // 
            this.toPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toPathTextBox.Location = new System.Drawing.Point(64, 6);
            this.toPathTextBox.Name = "toPathTextBox";
            this.toPathTextBox.Size = new System.Drawing.Size(263, 23);
            this.toPathTextBox.TabIndex = 4;
            this.toPathTextBox.TextChanged += new System.EventHandler(this.toPathTextBox_TextChanged);
            // 
            // filterLabel
            // 
            this.filterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterLabel.AutoSize = true;
            this.filterLabel.Location = new System.Drawing.Point(170, 46);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(33, 15);
            this.filterLabel.TabIndex = 5;
            this.filterLabel.Text = "Filter";
            // 
            // okayButton
            // 
            this.okayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okayButton.Location = new System.Drawing.Point(252, 249);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(75, 23);
            this.okayButton.TabIndex = 6;
            this.okayButton.Text = "Okay";
            this.okayButton.UseVisualStyleBackColor = true;
            this.okayButton.Click += new System.EventHandler(this.okayButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Leave the filters empty to delete Expulsion";
            // 
            // ExpulsionInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 284);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okayButton);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.toPathTextBox);
            this.Controls.Add(this.toPathLabel);
            this.Controls.Add(this.filterDataGridView);
            this.Controls.Add(this.limitNumericUpDown);
            this.Controls.Add(this.limitLabel);
            this.Name = "ExpulsionInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expulsion Input";
            ((System.ComponentModel.ISupportInitialize)(this.limitNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label limitLabel;
        private NumericUpDown limitNumericUpDown;
        private DataGridView filterDataGridView;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn limitColumn;
        private Label toPathLabel;
        private TextBox toPathTextBox;
        private Label filterLabel;
        private Button okayButton;
        private Label label1;
    }
}