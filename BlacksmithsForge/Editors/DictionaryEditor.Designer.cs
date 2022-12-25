namespace BlacksmithsForge.Editors
{
    partial class DictionaryEditor
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
            this.dictionaryDataGridView = new System.Windows.Forms.DataGridView();
            this.keyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okayButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dictionaryDataGridView
            // 
            this.dictionaryDataGridView.AllowUserToResizeColumns = false;
            this.dictionaryDataGridView.AllowUserToResizeRows = false;
            this.dictionaryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dictionaryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dictionaryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.keyColumn,
            this.valueColumn});
            this.dictionaryDataGridView.Location = new System.Drawing.Point(12, 12);
            this.dictionaryDataGridView.Name = "dictionaryDataGridView";
            this.dictionaryDataGridView.RowTemplate.Height = 25;
            this.dictionaryDataGridView.Size = new System.Drawing.Size(602, 397);
            this.dictionaryDataGridView.TabIndex = 0;
            this.dictionaryDataGridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dictionaryDataGridView_RowValidated);
            this.dictionaryDataGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dictionaryDataGridView_UserDeletedRow);
            // 
            // keyColumn
            // 
            this.keyColumn.HeaderText = "Key";
            this.keyColumn.Name = "keyColumn";
            // 
            // valueColumn
            // 
            this.valueColumn.HeaderText = "Value";
            this.valueColumn.Name = "valueColumn";
            // 
            // okayButton
            // 
            this.okayButton.Location = new System.Drawing.Point(276, 415);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(75, 23);
            this.okayButton.TabIndex = 1;
            this.okayButton.Text = "Okay";
            this.okayButton.UseVisualStyleBackColor = true;
            this.okayButton.Click += new System.EventHandler(this.okayButton_Click);
            // 
            // DictionaryEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 450);
            this.Controls.Add(this.okayButton);
            this.Controls.Add(this.dictionaryDataGridView);
            this.Name = "DictionaryEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DictionaryEditor";
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dictionaryDataGridView;
        private Button okayButton;
        private DataGridViewTextBoxColumn keyColumn;
        private DataGridViewTextBoxColumn valueColumn;
    }
}