using ScintillaNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlacksmithsForge.Editors
{
    public partial class SimpleTextInput : Form
    {
        public string? textValue;

        public SimpleTextInput(string input)
        {
            InitializeComponent();
            InitializeScintilla();

            textValue = input;
            scintilla1.Text = input;
            scintilla1.SelectAll();
        }

        public SimpleTextInput()
        {
            InitializeComponent();
            InitializeScintilla();
        }

        private void InitializeScintilla()
        {
            scintilla1.Styles[Style.Json.Default].ForeColor = Color.Silver;
            scintilla1.Styles[Style.Json.BlockComment].ForeColor = Color.Green; // Green
            scintilla1.Styles[Style.Json.LineComment].ForeColor = Color.Green; // Green
            scintilla1.Styles[Style.Json.Number].ForeColor = Color.Olive;
            scintilla1.Styles[Style.Json.PropertyName].ForeColor = Color.Blue;
            scintilla1.Styles[Style.Json.String].ForeColor = Color.FromArgb(163, 21, 21); // Red
            scintilla1.Styles[Style.Json.StringEol].BackColor = Color.Pink;
            scintilla1.Styles[Style.Json.Operator].ForeColor = Color.Purple;
            scintilla1.Styles[Style.Json.Keyword].ForeColor = Color.OrangeRed;

            scintilla1.SetKeywords(0, "true false");
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void scintilla1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(scintilla1.Text)) textValue = null;
            else textValue = scintilla1.Text;
        }
    }
}
