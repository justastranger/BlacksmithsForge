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
using System.Reflection.Metadata.Ecma335;
using BlacksmithsForge.Entities;

namespace BlacksmithsForge.Editors
{
    public partial class JsonTreeViewEditor : Form
    {
        public readonly JObject currentEntityData;
        public readonly Type entityType;

        private TreeNode? selectedNode;
        private JToken? selectedToken;

        public JsonTreeViewEditor(IEntity entityToEdit) : this(JObject.Parse(entityToEdit.ToString()), entityToEdit.GetType())
        {
            
        }

        public JsonTreeViewEditor(JObject entityToEdit, Type entityType)
        {
            currentEntityData = entityToEdit ?? throw new NullReferenceException("Can't edit a null JObject");
            InitializeComponent();
            this.entityType = entityType;
        }

        private void JsonTreeViewEditor_Load(object sender, EventArgs e)
        {
            string json = currentEntityData.ToString();
            jsonTreeView.LoadJsonToTreeView(json);
            jsonTreeView.TopNode.ExpandAll();
        }

        private void ReloadEntity()
        {
            jsonTreeView.Nodes.Clear();
            string json = currentEntityData.ToString();
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
            JToken? selectedToken = currentEntityData.SelectToken(jsonPath ?? throw new NullReferenceException("JSONPath of selected TreeNode is Null."));
            return selectedToken;
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
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
            selectedToken = currentEntityData.SelectToken(jsonPath) ?? throw new NullReferenceException("Null Token retrieved from Node.");

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
            selectedToken = currentEntityData.SelectToken(jsonPath) ?? throw new NullReferenceException("Null Token retrieved from Node.");

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
                        JToken value;
                        try
                        {
                            value = JToken.Parse(STI.textValue);
                        }
                        catch (JsonReaderException)
                        {
                            value = new JValue(STI.textValue.Replace("\"", ""));
                        }
                        //catch (ArgumentException)
                        //{
                        //    value = JObject.Parse(STI.textValue);
                        //}
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
            selectedToken = currentEntityData.SelectToken(jsonPath) ?? throw new NullReferenceException("Null Token retrieved from Node.");

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
            // make sure we have a selected node
            if (selectedNode == null) return;

            string? jsonPath = selectedNode.Tag?.ToString() ?? throw new NullReferenceException("Selected Node has null tag.");
            selectedToken = currentEntityData.SelectToken(jsonPath) ?? throw new NullReferenceException("Null Token retrieved from Node.");
            
            // Guard clause so only Objects are modified
            // Not specific enough to guard against Dictionary properties
            // TODO Either find a way to differentiate the two or merge the buttons
            if (selectedToken is not JObject jObject) return;

            KeyValueTextInput input = new();
            // if this is the root node, we know what autocomplete list to use
            if (selectedNode.Parent != null)
            {
                string rootName = ((jObject.Root as JObject).First as JProperty).Name;
                input.AddAutoCompleteForType(Utils.GetTypeFromRootName(rootName));
            }
            else
            {
                // TODO Determine the Entity type we're working with
                // Might be able to perform a lookup based on the root name, nesting level, and the name of the property that the Entity is being added to
                // Or use the JSONPath to determine the property name holding the entity being added to and do a lookup on the Entity object itself instead of the EntityData
                // This would return a correctly typed List or Dictionary, the type of which can be used to generate an AutoComplete suggestions list
                // The downside is that it would be a switch expression mapping the property names as strings to the Properties themselves which have getters that do the conversion automatically
            }

            if (input.ShowDialog() == DialogResult.OK)
            {
                if (!jObject.ContainsKey(input.Key))
                {
                    jObject.Add(ParseKeyValueInput(input.Key, input.Value));
                }
                else
                {
                    JProperty? existingProperty = currentEntityData.Property(input.Key);
                    existingProperty?.Replace(ParseKeyValueInput(input.Key, input.Value));
                }

                ReloadEntity();
            }
        }

        private static JProperty ParseKeyValueInput(string key, string value)
        {
            JProperty jProperty;
            if (int.TryParse(value, out int numberValue))
            {
                jProperty = new(key, numberValue);
            }
            else
            {
                try
                {
                    // try to parse as a non-string value
                    jProperty = new(key, JToken.Parse(value));
                }
                catch (JsonReaderException)
                {
                    // assume it was a string
                    jProperty = new(key, value);
                }
            }
            return jProperty;
        }

        private void deletePropertyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedNode == null || selectedNode.Parent == null) return;
            string? jsonPath = selectedNode.Tag?.ToString() ?? throw new NullReferenceException("Selected Node has null tag.");
            selectedToken = currentEntityData.SelectToken(jsonPath) ?? throw new NullReferenceException("Null Token retrieved from Node.");
            
            JToken actualToken = selectedToken.Parent ?? throw new NullReferenceException("Parent Token is Null.");

            if (MessageBox.Show("Are you sure you want to delete the following property?\n\n" + actualToken.ToString(), "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (actualToken.Type == JTokenType.Array)
                {
                    // this means selectedToken is one of the Array's values, and we don't want to remove the whole Array
                    selectedToken.Remove();
                }
                else
                {
                    actualToken.Remove();
                }
                ReloadEntity();
            }
        }

        private void recipeLinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (entityType != typeof(Element)
                && entityType != typeof(Legacy)
                && entityType != typeof(Portal)
                && entityType != typeof(Recipe))
            {
                MessageBox.Show("This type of entity does not support adding Recipes.");
                return;
            }

            // get the name of the property
            // if '$' is present, split and discard it and everything after it
            // then compare it to the properties that contain RecipeLinks
            // throw an error if it doesn't

            if (selectedNode == null || selectedNode.Parent == null) return;
            string? jsonPath = selectedNode.Tag?.ToString() ?? throw new NullReferenceException("Selected Node has null tag.");
            selectedToken = currentEntityData.SelectToken(jsonPath) ?? throw new NullReferenceException("Null Token retrieved from Node.");

            if (selectedToken is JArray jArray)
            {
                // Retrieve the name of the property, shedding the rest of the JSONPath and then trimming any Property Operations
                // TODO Determine if this is a valid action based on what the property operation is, if present
                string propertyName = selectedToken.Path.Split('.').Last().Split('$').First().ToLower();
                // This is somehow less work than a really long if
                // I'm sorry for exposing you to it
                switch (propertyName)
                {
                    case "induces":
                    case "startup":
                    case "consequences":
                    case "alt":
                    case "latealt":
                    case "linked":
                    case "inductions":
                        break;
                    default:
                        MessageBox.Show("Selected property node does not store RecipeLinks.", "Invalid Property Node", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                }

                RecipeLinkInput recipeLinkInput = new();
                if (recipeLinkInput.ShowDialog() == DialogResult.OK)
                {
                    jArray.Add(JObject.Parse(recipeLinkInput.RecipeLink.ToString()));
                    ReloadEntity();
                }

            }

        }

        private void sphereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (entityType != typeof(Element)
                && entityType != typeof(Recipe)
                && entityType != typeof(Verb))
            {
                MessageBox.Show("This type of entity does not support adding Spheres.");
                return;
            }

            // get the name of the property
            // if '$' is present, split and discard it and everything after it
            // then compare it to the properties that contain RecipeLinks
            // throw an error if it doesn't

            if (selectedNode == null || selectedNode.Parent == null) return;
            string? jsonPath = selectedNode.Tag?.ToString() ?? throw new NullReferenceException("Selected Node has null tag.");
            selectedToken = currentEntityData.SelectToken(jsonPath) ?? throw new NullReferenceException("Null Token retrieved from Node.");

            if (selectedToken is JArray jArray)
            {
                string propertyName = selectedToken.Path.Split('.').Last().Split('$').First().ToLower();
                // This is somehow less work than a really long if
                // I'm sorry for exposing you to it
                switch (propertyName)
                {
                    case "slots":
                    case "slot":
                        break;
                    default:
                        MessageBox.Show("Selected property node does not store Spheres.", "Invalid Property Node", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                }

                RecipeLinkInput recipeLinkInput = new();
                if (recipeLinkInput.ShowDialog() == DialogResult.OK)
                {
                    jArray.Add(JObject.Parse(recipeLinkInput.RecipeLink.ToString()));
                    ReloadEntity();
                }

            }
        }

        private void dictionaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedNode == null) return;

            string? jsonPath = selectedNode.Tag?.ToString() ?? throw new NullReferenceException("Selected Node has null tag.");
            selectedToken = currentEntityData.SelectToken(jsonPath) ?? throw new NullReferenceException("Null Token retrieved from Node.");

            if (selectedToken is not JObject jObject) return;

            SimpleTextInput STI = new("Put the name of your Dictionary here.");
            if (STI.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(STI.textValue))
            {
                string dictName = STI.textValue;

                DictionaryEditor dictionaryEditor = new(new());
                if (dictionaryEditor.ShowDialog() == DialogResult.OK && dictionaryEditor.Dictionary.Count > 0)
                {
                    if (jObject.ContainsKey(dictName))
                    {
                        jObject[dictName] = JObject.FromObject(dictionaryEditor.Dictionary);
                    }
                    else
                    {
                        JProperty jProperty = new(dictName, JObject.FromObject(dictionaryEditor.Dictionary));
                        jObject.Add(jProperty);
                    }
                    ReloadEntity();
                }
            }

        }
    }
}
