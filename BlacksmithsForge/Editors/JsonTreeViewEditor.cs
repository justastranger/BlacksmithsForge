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
        }

        private void jsonTreeView_MouseDown(object sender, MouseEventArgs e)
        {
            selectedNode = jsonTreeView.GetNodeAt(e.X, e.Y);
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
                // show the entire EntityData to prove the value was updated
                // MessageBox.Show(currentEntity.ToString());
            }
        }

        private void jsonTreeView_DoubleClick(object sender, EventArgs e)
        {
            if (selectedNode != null && selectedNode.Parent != null)
            {
                jsonTreeView.SelectedNode = selectedNode;
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
    }
}
