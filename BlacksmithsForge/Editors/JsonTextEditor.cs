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
    public partial class JsonTextEditor : Form
    {
        public string jsonText;
        string tmpText;

        public JsonTextEditor(string text)
        {
            InitializeComponent();
            InitializeScintilla();
            jsonText = text;
            scintilla1.Text = jsonText;
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

        private void scintilla1_TextChanged(object sender, EventArgs e)
        {
            tmpText = scintilla1.Text;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            jsonText = tmpText;
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
