namespace BlacksmithsForge.Editors
{
    partial class KeyValueTextInput
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
            this.label1 = new System.Windows.Forms.Label();
            this.valueScintilla = new ScintillaNET.Scintilla();
            this.okayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 27);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(348, 23);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(87, 15);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Property Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Property Value";
            // 
            // valueScintilla
            // 
            this.valueScintilla.AutoCMaxHeight = 9;
            this.valueScintilla.BiDirectionality = ScintillaNET.BiDirectionalDisplayType.Disabled;
            this.valueScintilla.CaretLineBackColor = System.Drawing.Color.White;
            this.valueScintilla.CaretLineVisible = true;
            this.valueScintilla.Lexer = ScintillaNET.Lexer.Json;
            this.valueScintilla.LexerName = "json";
            this.valueScintilla.Location = new System.Drawing.Point(12, 71);
            this.valueScintilla.Name = "valueScintilla";
            this.valueScintilla.ScrollWidth = 49;
            this.valueScintilla.Size = new System.Drawing.Size(348, 221);
            this.valueScintilla.TabIndents = true;
            this.valueScintilla.TabIndex = 4;
            this.valueScintilla.UseRightToLeftReadingLayout = false;
            this.valueScintilla.WrapMode = ScintillaNET.WrapMode.None;
            this.valueScintilla.TextChanged += new System.EventHandler(this.valueScintilla_TextChanged);
            // 
            // okayButton
            // 
            this.okayButton.Location = new System.Drawing.Point(149, 298);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(75, 23);
            this.okayButton.TabIndex = 5;
            this.okayButton.Text = "Okay";
            this.okayButton.UseVisualStyleBackColor = true;
            this.okayButton.Click += new System.EventHandler(this.okayButton_Click);
            // 
            // KeyValueTextInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 333);
            this.Controls.Add(this.okayButton);
            this.Controls.Add(this.valueScintilla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Name = "KeyValueTextInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Key Value Text Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nameTextBox;
        private Label nameLabel;
        private Label label1;
        private ScintillaNET.Scintilla valueScintilla;
        private Button okayButton;
    }
}