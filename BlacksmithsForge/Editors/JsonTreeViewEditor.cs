using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlacksmithsForge.Extensions;
using Newtonsoft.Json;

namespace BlacksmithsForge.Editors
{
    public partial class JsonTreeViewEditor : Form
    {
        public readonly JObject currentEntity;

        private TreeNode? selectedNode;
        private JToken? selectedToken;

        public JsonTreeViewEditor(JObject entityToEdit)
        {
            currentEntity = entityToEdit ?? throw new NullReferenceException("Can't edit a null JObject");
            InitializeComponent();
        }

        private void JsonTreeViewEditor_Load(object sender, EventArgs e)
        {
            string json = currentEntity.ToString();
            jsonTreeView.LoadJsonToTreeView(json);
            jsonTreeView.TopNode.ExpandAll();
        }

        private void ReloadEntity()
        {
            jsonTreeView.Nodes.Clear();
            string json = currentEntity.ToString();
            jsonTreeView.LoadJsonToTreeView(json);
            jsonTreeView.TopNode.ExpandAll();
        }

        private void jsonTreeView_MouseDown(object sender, MouseEventArgs e)
        {
            selectedNode = jsonTreeView.GetNodeAt(e.X, e.Y);
            jsonTreeView.SelectedNode = selectedNode;
        }

        private void jsonTreeView_Click(object sender, EventArgs e)
        {
            
        }

        private void jsonTreeView_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            // no changes were made
            if (e.Label == null) return;
            
            // if we have a Value selected
            if (selectedToken is JValue jValue)
            {
                int numberValue = 0;
                if (int.TryParse(e.Label, out numberValue))
                {
                    jValue.Value = numberValue;
                }
                else
                {
                    // update the Value as a string
                    jValue.Value = e.Label;
                }
                jsonTreeView.LabelEdit = false;
                ReloadEntity();
            }
        }

        private void jsonTreeView_DoubleClick(object sender, EventArgs e)
        {
            if (selectedNode != null && selectedNode.Parent != null)
            {
                // jsonTreeView.SelectedNode = selectedNode;
                // Node containing Property name
                if (selectedNode.Nodes.Count == 1)
                {
                    // Property nodes are always created with the Value node as the only child
                    // Array nodes have indexes as children and don't parse to a JValue, preventing mishaps
                    selectedNode = selectedNode.FirstNode;
                    jsonTreeView.SelectedNode = selectedNode;
                }
                else if (selectedNode.Nodes.Count > 1)
                {
                    // probably an Array's root node
                    return;
                }

                // Only a Value node should be selected by now
                // but just to make sure, return if there's any more child nodes below
                if (selectedNode.Nodes.Count > 0) return;

                // check if the node has a tag and return if it doesn't
                // All nodes should have tags though
                if (selectedNode.Tag == null) return;


                // Try to find the relevant token
                JToken? token = SelectTokenFromNodeTag(selectedNode);
                // if the selected token is the Value token
                if (token is JValue) // value)
                {
                    // hold onto the token for later so it can be updated
                    selectedToken = token;
                    // put treeview and the node into editing mode
                    jsonTreeView.LabelEdit = true;
                    if (!selectedNode.IsEditing) selectedNode.BeginEdit();
                    // MessageBox.Show($"{value.Path}: {value.Value}");
                }
            }
            else
            {
                // invalid selection, root node
            }
        }

        private JToken? SelectTokenFromNodeTag(TreeNode nodeToFollow)
        {
            string? jsonPath = nodeToFollow.Tag.ToString();
            JToken? selectedToken = currentEntity.SelectToken(jsonPath ?? throw new NullReferenceException("JSONPath of selected TreeNode is Null."));
            return selectedToken;
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editPropertyNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Return if:
            // No Node selected or Root Node selected
            if (selectedNode == null || selectedNode.Parent == null) return;
            // Node is a value, having no children
            // check for JValue below
            // if (selectedNode.Nodes.Count == 0) return;

            string? jsonPath = selectedNode.Tag?.ToString() ?? throw new NullReferenceException("Selected Node has null tag.");
            selectedToken = currentEntity.SelectToken(jsonPath) ?? throw new NullReferenceException("Null Token retrieved from Node.");

            // is this even necessary anymore with the pattern matching expression below?
            if (selectedToken is JValue) return;

            // JProperty jProperty = (JProperty?)selectedToken.Parent ?? throw new NullReferenceException("Selected Token's Parent is Null.");
            if (selectedToken.Parent is JProperty jProperty)
            {
                // put property name through editor
                SimpleTextInput STI = new(jProperty.Name);
                STI.ShowDialog();
                // if it's changed and not null/empty
                if (STI.textValue != jProperty.Name && !String.IsNullOrEmpty(STI.textValue))
                {
                    // update it and the node's text
                    JProperty newProperty = new(STI.textValue, jProperty.Value);
                    jProperty.Replace(newProperty);
                    selectedNode.Text = STI.textValue;

                    ReloadEntity();
                }
            }
        }

        private void addEntryToArrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedNode == null || selectedNode.Parent == null) return;
            string? jsonPath = selectedNode.Tag?.ToString() ?? throw new NullReferenceException("Selected Node has null tag.");
            selectedToken = currentEntity.SelectToken(jsonPath) ?? throw new NullReferenceException("Null Token retrieved from Node.");

            if (selectedToken is JArray jArray)
            {
                SimpleTextInput STI = new();
                if (STI.ShowDialog() == DialogResult.OK)
                {
                    if (int.TryParse(STI.textValue, out int numberValue))
                    {
                        jArray.Add(numberValue);
                    }
                    else
                    {
                        // Allows for arbitrary JSON to be used as a value
                        // Or for simple values like strings, numbers, bools
                        JValue value;
                        try
                        {
                            value = new(JToken.Parse(STI.textValue));
                        }
                        catch (JsonReaderException)
                        {
                            value = new(STI.textValue);
                        }
                        jArray.Add(value);
                    }
                    

                    ReloadEntity();
                }
            }

        }

        private void addEntryToDictionaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedNode == null || selectedNode.Parent == null) return;
            string? jsonPath = selectedNode.Tag?.ToString() ?? throw new NullReferenceException("Selected Node has null tag.");
            selectedToken = currentEntity.SelectToken(jsonPath) ?? throw new NullReferenceException("Null Token retrieved from Node.");

            if (selectedToken is JObject jObject)
            {
                KeyValueTextInput input = new();
                if (input.ShowDialog() == DialogResult.OK)
                {
                    JProperty jProperty;
                    if (int.TryParse(input.Value, out int numberValue))
                    {
                          jProperty = new(input.Key, numberValue);
                    }
                    else
                    {
                        try
                        {
                            // try to parse as a non-string value
                            jProperty = new(input.Key, JToken.Parse(input.Value));
                        }
                        catch (JsonReaderException)
                        {
                            // assume it was a string
                            jProperty = new(input.Key, input.Value);
                        }
                    }
                    jObject.Add(jProperty);
                    ReloadEntity();
                }
            }
        }

        private void addPropertyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedNode == null) return;
            string? jsonPath = selectedNode.Tag?.ToString() ?? throw new NullReferenceException("Selected Node has null tag.");
            selectedToken = currentEntity.SelectToken(jsonPath) ?? throw new NullReferenceException("Null Token retrieved from Node.");

            if (selectedToken is JObject jObject)
            {
                KeyValueTextInput input = new();
                if (input.ShowDialog() == DialogResult.OK)
                {
                    JProperty jProperty;
                    if (int.TryParse(input.Value, out int numberValue))
                    {
                        jProperty = new(input.Key, numberValue);
                    }
                    else
                    {
                        try
                        {
                            // try to parse as a non-string value
                            jProperty = new(input.Key, JToken.Parse(input.Value));
                        }
                        catch (JsonReaderException)
                        {
                            // assume it was a string
                            jProperty = new(input.Key, input.Value);
                        }
                    }
                    jObject.Add(jProperty);
                    ReloadEntity();
                }
            }
        }
    }
}
