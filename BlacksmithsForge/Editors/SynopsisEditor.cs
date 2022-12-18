using BlacksmithsForge.Mods;
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
    public partial class SynopsisEditor : Form
    {
        private Synopsis Synopsis;

        public SynopsisEditor(ref Synopsis synopsis)
        {
            InitializeComponent();

            Synopsis = synopsis;
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nameTextBox.Text)) Synopsis.Name = "";
            else Synopsis.Name = nameTextBox.Text;
        }

        private void authorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(authorTextBox.Text)) Synopsis.Author = "";
            else Synopsis.Author = authorTextBox.Text;
        }

        private void versionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(versionTextBox.Text)) Synopsis.Version = null;
            else Synopsis.Version = versionTextBox.Text;
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(descriptionTextBox.Text)) Synopsis.Description = null;
            else Synopsis.Description = descriptionTextBox.Text;
        }

        private void longDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(longDescriptionTextBox.Text)) Synopsis.Description_Long = null;
            else Synopsis.Description_Long = longDescriptionTextBox.Text;
        }

        private void addDependencyButton_Click(object sender, EventArgs e)
        {
            string tmp = "";
            SimpleTextInput STI = new(ref tmp);
            STI.Show();
            if (tmp != "")
            {
                dependenciesListBox.Items.Add(tmp);
            }
        }

        private void removeDependencyButton_Click(object sender, EventArgs e)
        {
            if (dependenciesListBox.SelectedItem != null) dependenciesListBox.Items.Remove(dependenciesListBox.SelectedItem);
        }

        private void addTagButton_Click(object sender, EventArgs e)
        {
            string tmp = "";
            SimpleTextInput STI = new(ref tmp);
            STI.Show();
            if (tmp != "")
            {
                tagsListBox.Items.Add(tmp);
            }
        }

        private void removeTagButton_Click(object sender, EventArgs e)
        {
            if (tagsListBox.SelectedItem != null) tagsListBox.Items.Remove(tagsListBox.SelectedItem);
        }
    }
}
