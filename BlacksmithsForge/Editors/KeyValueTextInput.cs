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
    public partial class KeyValueTextInput : Form
    {
        public string Key;
        public string Value;

        public KeyValueTextInput(string key, string value)
        {
            InitializeComponent();
            InitializeScintilla();
            Key = key;
            Value = value;
        }

        public KeyValueTextInput(string key) : this(key, "")
        {

        }

        public KeyValueTextInput() : this("", "")
        {

        }

        public KeyValueTextInput(Type entityType) : this("", "")
        {
            AddAutoCompleteForType(entityType);
        }

        public void AddAutoCompleteSuggestionList(List<string> suggestions)
        {
            nameTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            nameTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            var source = new AutoCompleteStringCollection();
            source.AddRange(suggestions.ToArray());
            nameTextBox.AutoCompleteCustomSource = source;
        }

        public void AddAutoCompleteForType(Type entityType)
        {
            AddAutoCompleteSuggestionList(Utils.GetEntityPropertyNames(entityType));
        }

        private void InitializeScintilla()
        {
            valueScintilla.Styles[Style.Json.Default].ForeColor = Color.Silver;
            valueScintilla.Styles[Style.Json.BlockComment].ForeColor = Color.Green; // Green
            valueScintilla.Styles[Style.Json.LineComment].ForeColor = Color.Green; // Green
            valueScintilla.Styles[Style.Json.Number].ForeColor = Color.Olive;
            valueScintilla.Styles[Style.Json.PropertyName].ForeColor = Color.Blue;
            valueScintilla.Styles[Style.Json.String].ForeColor = Color.FromArgb(163, 21, 21); // Red
            valueScintilla.Styles[Style.Json.StringEol].BackColor = Color.Pink;
            valueScintilla.Styles[Style.Json.Operator].ForeColor = Color.Purple;
            valueScintilla.Styles[Style.Json.Keyword].ForeColor = Color.OrangeRed;

            valueScintilla.SetKeywords(0, "true false");
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            Key = nameTextBox.Text;
        }

        private void valueScintilla_TextChanged(object sender, EventArgs e)
        {
            Value = valueScintilla.Text;
        }
    }
}
