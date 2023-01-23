namespace BlacksmithsForge.Editors
{
    partial class XTriggerInput
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
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.chanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.chanceLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.levelNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.morphEffectTypeComboBox = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.okayButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chanceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idTextBox.Location = new System.Drawing.Point(12, 27);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(198, 23);
            this.idTextBox.TabIndex = 0;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(12, 9);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(53, 15);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "Target ID";
            // 
            // chanceNumericUpDown
            // 
            this.chanceNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chanceNumericUpDown.Location = new System.Drawing.Point(12, 71);
            this.chanceNumericUpDown.Name = "chanceNumericUpDown";
            this.chanceNumericUpDown.Size = new System.Drawing.Size(198, 23);
            this.chanceNumericUpDown.TabIndex = 2;
            this.chanceNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.chanceNumericUpDown.ValueChanged += new System.EventHandler(this.chanceNumericUpDown_ValueChanged);
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
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(12, 97);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(34, 15);
            this.levelLabel.TabIndex = 4;
            this.levelLabel.Text = "Level";
            // 
            // levelNumericUpDown
            // 
            this.levelNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.levelNumericUpDown.Location = new System.Drawing.Point(12, 115);
            this.levelNumericUpDown.Name = "levelNumericUpDown";
            this.levelNumericUpDown.Size = new System.Drawing.Size(198, 23);
            this.levelNumericUpDown.TabIndex = 5;
            this.levelNumericUpDown.ValueChanged += new System.EventHandler(this.levelNumericUpDown_ValueChanged);
            // 
            // morphEffectTypeComboBox
            // 
            this.morphEffectTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.morphEffectTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.morphEffectTypeComboBox.FormattingEnabled = true;
            this.morphEffectTypeComboBox.Items.AddRange(new object[] {
            "Transform",
            "Spawn",
            "Mutate"});
            this.morphEffectTypeComboBox.Location = new System.Drawing.Point(12, 159);
            this.morphEffectTypeComboBox.Name = "morphEffectTypeComboBox";
            this.morphEffectTypeComboBox.Size = new System.Drawing.Size(198, 23);
            this.morphEffectTypeComboBox.TabIndex = 6;
            this.morphEffectTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.morphEffectTypeComboBox_SelectedIndexChanged);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(12, 141);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(77, 15);
            this.typeLabel.TabIndex = 7;
            this.typeLabel.Text = "XTrigger Type";
            // 
            // okayButton
            // 
            this.okayButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.okayButton.Location = new System.Drawing.Point(67, 194);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(89, 23);
            this.okayButton.TabIndex = 8;
            this.okayButton.Text = "Okay";
            this.okayButton.UseVisualStyleBackColor = true;
            // 
            // XTriggerInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 229);
            this.Controls.Add(this.okayButton);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.morphEffectTypeComboBox);
            this.Controls.Add(this.levelNumericUpDown);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.chanceLabel);
            this.Controls.Add(this.chanceNumericUpDown);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idTextBox);
            this.MinimumSize = new System.Drawing.Size(238, 268);
            this.Name = "XTriggerInput";
            this.Text = "XTrigger Input";
            ((System.ComponentModel.ISupportInitialize)(this.chanceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox idTextBox;
        private Label idLabel;
        private NumericUpDown chanceNumericUpDown;
        private Label chanceLabel;
        private Label levelLabel;
        private NumericUpDown levelNumericUpDown;
        private ComboBox morphEffectTypeComboBox;
        private Label typeLabel;
        private Button okayButton;
    }
}