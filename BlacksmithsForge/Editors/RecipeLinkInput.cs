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
    public partial class RecipeLinkInput : Form
    {
        public RecipeLink RecipeLink;

        public RecipeLinkInput(RecipeLink recipeLink)
        {
            InitializeComponent();
            RecipeLink = recipeLink;
            LoadValues();
        }

        public RecipeLinkInput() : this(new("CHANGEME.recipe.target"))
        {
            
        }

        private void additionalCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (additionalCheckBox.Checked) RecipeLink.Additional = true;
            else RecipeLink.Additional = null;
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {
            RecipeLink.ID = idTextBox.Text;
        }

        private void chanceNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (chanceNumericUpDown.Value == 100) RecipeLink.Chance = null;
            else RecipeLink.Chance = (int)chanceNumericUpDown.Value;
        }

        private void toPathTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(toPathTextBox.Text)) RecipeLink.ToPath = null;
            else RecipeLink.ToPath = toPathTextBox.Text;
        }

        private void challengesDataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (challengesDataGridView.Rows[e.RowIndex].Cells[0].Value != null && challengesDataGridView.Rows[e.RowIndex].Cells[1].Value != null)
            {
                UpdateChallenges();
            }
        }

        private void UpdateChallenges()
        {
            Dictionary<string,string>? Challenges = new();

            foreach (DataGridViewRow row in challengesDataGridView.Rows)
            {
                // Look for rows where both cells are filled
                if (row.Cells[0].Value?.ToString() != null && row.Cells[1].Value?.ToString() != null)
                {
                    // null checked above, idk why it is so damned sure there's a null reference possibility
                    string key = row.Cells[0].Value.ToString();
                    string value = row.Cells[1].Value.ToString();

                    Challenges.Add(key, value);
                }
            }

            if (Challenges.Count == 0)
            {
                Challenges = null;
            }

            RecipeLink.Challenges = Challenges;

            // ReloadDataGridView();
        }

        private void LoadValues()
        {
            idTextBox.Text = RecipeLink.ID;
            // 100 is functionally the same as null, a guaranteed link
            chanceNumericUpDown.Value = RecipeLink.Chance ?? 100;
            additionalCheckBox.Checked = RecipeLink.Additional ?? false;
            toPathTextBox.Text = RecipeLink.ToPath ?? "";

            // Empty DataGridViews that can have rows added always start with one blank
            // And always immediately add a second row once the first starts being filled
            if (challengesDataGridView.Rows.Count > 1) challengesDataGridView.Rows.Clear();

            if (RecipeLink.Challenges?.Count > 0)
            {
                RecipeLink.Challenges?.ToList().ForEach(pair =>
                {
                    challengesDataGridView.Rows.Add(pair.Key, pair.Value);
                });
            }
        }

        private void challengesDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[1].Value = "base";
        }

        private void challengesDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            UpdateChallenges();
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RecipeLink.ID) || RecipeLink.ID == "CHANGEME.recipe.target")
            {
                MessageBox.Show("You must set the ID to target a recipe.. To cancel, click the close button in the top right.");
                return;
            }
            UpdateChallenges();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void expulsionButton_Click(object sender, EventArgs e)
        {
            Expulsion expulsion = new();
            ExpulsionInput expulsionInput = new(expulsion);
            expulsionInput.ShowDialog();
            if (expulsionInput.Expulsion.Filter != null)
            {
                RecipeLink.Expulsion = expulsion;
            }
        }
    }
}
