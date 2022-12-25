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
            LoadValues();
        }

        private void LoadValues()
        {
            toPathTextBox.Text = Expulsion.ToPath ?? "";
            limitNumericUpDown.Value = Expulsion.Limit ?? 0;

            // will have 1 row when blank
            if (filterDataGridView.Rows.Count > 1) filterDataGridView.Rows.Clear();
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
            // one last pass to make sure it's current
            UpdateFilter();
            DialogResult = DialogResult.OK;
            Close();
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

        private void UpdateFilter()
        {
            Expulsion.Filter = new();

            foreach (DataGridViewRow row in filterDataGridView.Rows)
            {
                // Look for rows where both cells are filled
                // Ignore the rest, but leave their rows/cells in place in case they're filled out later
                if (row.Cells[0].Value?.ToString() != null && row.Cells[1].Value?.ToString() != null)
                {
                    // null checked above, idk why it is so damned sure there's a null reference possibility
                    string key = row.Cells[0].Value.ToString();
                    string value = row.Cells[1].Value.ToString();

                    Expulsion.Filter.Add(key, value);
                }
            }

            if (Expulsion.Filter.Count == 0)
            {
                // This basically renders the expulsion useless but if it's empty it's empty and we don't need stragglers
                Expulsion.Filter = null;
            }
        }

        private void filterDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            UpdateFilter();
        }

        private void filterDataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            // If both cells were filled, initiate saving
            if (filterDataGridView.Rows[e.RowIndex].Cells[0].Value != null && filterDataGridView.Rows[e.RowIndex].Cells[1].Value != null)
            {
                UpdateFilter();
            }
        }
    }
}
