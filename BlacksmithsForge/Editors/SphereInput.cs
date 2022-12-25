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
    public partial class SphereInput : Form
    {
        public Sphere Sphere;

        public SphereInput(Sphere sphere)
        {
            InitializeComponent();
            Sphere = sphere;
        }

        private void greedyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (greedyCheckBox.Checked) Sphere.Greedy = true;
            else Sphere.Greedy = null;
        }

        private void consumesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (consumesCheckBox.Checked) Sphere.Consumes = true;
            else Sphere.Consumes = null;
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(idTextBox.Text)) Sphere.ID = idTextBox.Text;
        }

        private void labelTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(labelTextBox.Text)) Sphere.Label = labelTextBox.Text;
            else Sphere.Label = null;
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(descriptionTextBox.Text)) Sphere.Description = descriptionTextBox.Text;
            else Sphere.Description = null;
        }

        private void actionIdTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(actionIdTextBox.Text)) Sphere.ActionId = actionIdTextBox.Text;
            else Sphere.ActionId = null;
        }

        private void fromPathTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fromPathTextBox.Text)) Sphere.FromPath = fromPathTextBox.Text;
            else Sphere.FromPath = null;
        }

        private void enRouteSpherePathTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(enRouteSpherePathTextBox.Text)) Sphere.EnRouteSpherePath = enRouteSpherePathTextBox.Text;
            else Sphere.EnRouteSpherePath = null;
        }

        private void windowsSpherePathTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(windowsSpherePathTextBox.Text)) Sphere.WindowsSpherePath = windowsSpherePathTextBox.Text;
            else Sphere.WindowsSpherePath = null;
        }

        private void essentialButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> essential = Sphere.Essential ?? new();
            DictionaryEditor dictionaryEditor = new(essential != null ? essential.ToDictionary(entry => entry.Key, entry => (object)entry.Value) : new());
            if (dictionaryEditor.ShowDialog() == DialogResult.OK)
            {
                if (dictionaryEditor.Dictionary.Count > 0) Sphere.Essential = dictionaryEditor.Dictionary.ToDictionary(entry => entry.Key, entry => Convert.ToInt32(entry.Value));
                else Sphere.Essential = null;
            }
        }

        private void requiredButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> required = Sphere.Required ?? new();
            DictionaryEditor dictionaryEditor = new(required != null ? required.ToDictionary(entry => entry.Key, entry => (object)entry.Value) : new());
            if (dictionaryEditor.ShowDialog() == DialogResult.OK)
            {
                if (dictionaryEditor.Dictionary.Count > 0) Sphere.Required = dictionaryEditor.Dictionary.ToDictionary(entry => entry.Key, entry => Convert.ToInt32(entry.Value));
                else Sphere.Required = null;
            }
        }

        private void forbiddenButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> forbidden = Sphere.Forbidden ?? new();
            DictionaryEditor dictionaryEditor = new(forbidden != null ? forbidden.ToDictionary(entry => entry.Key, entry => (object)entry.Value) : new());
            if (dictionaryEditor.ShowDialog() == DialogResult.OK)
            {
                if (dictionaryEditor.Dictionary.Count > 0) Sphere.Forbidden = dictionaryEditor.Dictionary.ToDictionary(entry => entry.Key, entry => Convert.ToInt32(entry.Value));
                else Sphere.Forbidden = null;
            }
        }

        private void ifAspectsPresentButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> ifAspectsPresent = Sphere.IfAspectsPresent ?? new();
            DictionaryEditor dictionaryEditor = new(ifAspectsPresent != null ? ifAspectsPresent.ToDictionary(entry => entry.Key, entry => (object)entry.Value) : new());
            if (dictionaryEditor.ShowDialog() == DialogResult.OK)
            {
                if (dictionaryEditor.Dictionary.Count > 0) Sphere.IfAspectsPresent = dictionaryEditor.Dictionary.ToDictionary(entry => entry.Key, entry => entry.Value.ToString());
                else Sphere.IfAspectsPresent = null;
            }
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
