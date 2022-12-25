using BlacksmithsForge.Entities;
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
    public partial class ExpulsionInput : Form
    {
        public Expulsion Expulsion;

        public ExpulsionInput(Expulsion expulsion)
        {
            InitializeComponent();
            Expulsion = expulsion;
        }

        private void LoadValues()
        {
            toPathTextBox.Text = Expulsion.ToPath ?? "";
            limitNumericUpDown.Value = Expulsion.Limit ?? 0;

            if (filterDataGridView.Rows.Count > 0) filterDataGridView.Rows.Clear();
            if (Expulsion.Filter?.Count > 0)
            {
                foreach (var pair in Expulsion.Filter)
                {
                    filterDataGridView.Rows.Add(pair.Key, pair.Value);
                }
            }

        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void toPathTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(toPathTextBox.Text)) Expulsion.ToPath = null;
            else Expulsion.ToPath = toPathTextBox.Text;
        }

        private void limitNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (limitNumericUpDown.Value == 0) Expulsion.Limit = null;
            else Expulsion.Limit = (int)limitNumericUpDown.Value;
        }
    }
}
