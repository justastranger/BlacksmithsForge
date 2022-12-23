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
            ((System.ComponentModel.ISupportInitialize)(this.chanceNumericUpDown)).BeginInit();
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
            this.idTextBox.Location = new System.Drawing.Point(12, 27);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 23);
            this.idTextBox.TabIndex = 1;
            // 
            // chanceNumericUpDown
            // 
            this.chanceNumericUpDown.Location = new System.Drawing.Point(12, 71);
            this.chanceNumericUpDown.Name = "chanceNumericUpDown";
            this.chanceNumericUpDown.Size = new System.Drawing.Size(100, 23);
            this.chanceNumericUpDown.TabIndex = 2;
            // 
            // chanceLabel
            // 
            this.chanceLabel.AutoSize = true;
            this.chanceLabel.Location = new System.Drawing.Point(12, 53);
            this.chanceLabel.Name = "chanceLabel";
            this.chanceLabel.Size = new System.Drawing.Size(47, 15);
            this.chanceLabel.TabIndex = 3;
            this.chanceLabel.Text = "Chance";
            // 
            // additionalCheckBox
            // 
            this.additionalCheckBox.AutoSize = true;
            this.additionalCheckBox.Location = new System.Drawing.Point(12, 100);
            this.additionalCheckBox.Name = "additionalCheckBox";
            this.additionalCheckBox.Size = new System.Drawing.Size(81, 19);
            this.additionalCheckBox.TabIndex = 4;
            this.additionalCheckBox.Text = "Additional";
            this.additionalCheckBox.UseVisualStyleBackColor = true;
            this.additionalCheckBox.CheckedChanged += new System.EventHandler(this.additionalCheckBox_CheckedChanged);
            // 
            // RecipeLinkInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.additionalCheckBox);
            this.Controls.Add(this.chanceLabel);
            this.Controls.Add(this.chanceNumericUpDown);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Name = "RecipeLinkInput";
            this.Text = "RecipeLinkInput";
            ((System.ComponentModel.ISupportInitialize)(this.chanceNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label idLabel;
        private TextBox idTextBox;
        private NumericUpDown chanceNumericUpDown;
        private Label chanceLabel;
        private CheckBox additionalCheckBox;
    }
}