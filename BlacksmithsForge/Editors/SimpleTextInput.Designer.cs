namespace BlacksmithsForge.Editors
{
    partial class SimpleTextInput
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
            this.okayButton = new System.Windows.Forms.Button();
            this.scintilla1 = new ScintillaNET.Scintilla();
            this.SuspendLayout();
            // 
            // okayButton
            // 
            this.okayButton.Location = new System.Drawing.Point(178, 197);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(75, 23);
            this.okayButton.TabIndex = 1;
            this.okayButton.Text = "OK";
            this.okayButton.UseVisualStyleBackColor = true;
            this.okayButton.Click += new System.EventHandler(this.okayButton_Click);
            // 
            // scintilla1
            // 
            this.scintilla1.AutoCMaxHeight = 9;
            this.scintilla1.BiDirectionality = ScintillaNET.BiDirectionalDisplayType.Disabled;
            this.scintilla1.CaretLineBackColor = System.Drawing.Color.Black;
            this.scintilla1.Lexer = ScintillaNET.Lexer.Json;
            this.scintilla1.LexerName = "json";
            this.scintilla1.Location = new System.Drawing.Point(12, 12);
            this.scintilla1.Name = "scintilla1";
            this.scintilla1.ScrollWidth = 49;
            this.scintilla1.Size = new System.Drawing.Size(407, 179);
            this.scintilla1.TabIndents = true;
            this.scintilla1.TabIndex = 2;
            this.scintilla1.UseRightToLeftReadingLayout = false;
            this.scintilla1.WrapMode = ScintillaNET.WrapMode.None;
            this.scintilla1.Click += new System.EventHandler(this.textBox_TextChanged);
            // 
            // SimpleTextInput
            // 
            this.AcceptButton = this.okayButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 236);
            this.Controls.Add(this.scintilla1);
            this.Controls.Add(this.okayButton);
            this.Name = "SimpleTextInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Text Input";
            this.ResumeLayout(false);

        }

        #endregion
        private Button okayButton;
        private ScintillaNET.Scintilla scintilla1;
    }
}