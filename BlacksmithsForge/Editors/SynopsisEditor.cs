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

            FillValues();
        }

        private void FillValues()
        {
            nameTextBox.Text = Synopsis.Name;
            authorTextBox.Text = Synopsis.Author;
            versionTextBox.Text = Synopsis.Version;
            descriptionTextBox.Text = Synopsis.Description;
            longDescriptionTextBox.Text = Synopsis.Description_Long;
            if (Synopsis.Tags != null && Synopsis.Tags.Count > 0)
            {
                Synopsis.Tags.ForEach((string tag) => { tagsListBox.Items.Add(tag); });
            }
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
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

        private void addTagButton_Click(object sender, EventArgs e)
        {
            SimpleTextInput STI = new();
            STI.ShowDialog();
            if (!String.IsNullOrEmpty(STI.textValue))
            {
                tagsListBox.Items.Add(STI.textValue);
            }
        }

        private void removeTagButton_Click(object sender, EventArgs e)
        {
            if (tagsListBox.SelectedItem != null) tagsListBox.Items.Remove(tagsListBox.SelectedItem);
        }
    }
}
