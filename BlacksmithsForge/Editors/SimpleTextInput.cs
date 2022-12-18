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
        public string? textInput;

        public SimpleTextInput(ref string input)
        {
            InitializeComponent();

            textInput = input;

            textBox.Text = input;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox.Text)) textInput = null;
            else textInput = textBox.Text;
        }
    }
}
