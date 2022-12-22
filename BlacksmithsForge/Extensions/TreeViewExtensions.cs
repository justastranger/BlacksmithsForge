using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithsForge.Extensions
{
    // Extension found here
    // Licensed under MIT
    // https://github.com/huseyint/JsonTreeView/blob/master/JsonTreeView/JsonTreeViewLoader.cs

    internal static class TreeViewExtensions
    {
        public static void LoadJsonToTreeView(this TreeView treeView, string json)
        {
            if (string.IsNullOrWhiteSpace(json))
            {
                return;
            }

            var @object = JObject.Parse(json);
            AddObjectNodes(@object, "JSON", treeView.Nodes);
        }

        public static void AddObjectNodes(JObject @object, string name, TreeNodeCollection parent)
        {
            var node = new TreeNode(name) { Tag = @object.Path };
            parent.Add(node);

            foreach (var property in @object.Properties())
            {
                AddTokenNodes(property.Value, property.Name, node.Nodes);
            }
        }

        private static void AddArrayNodes(JArray array, string name, TreeNodeCollection parent)
        {
            var node = new TreeNode(name) { Tag = array.Path };
            parent.Add(node);

            for (var i = 0; i < array.Count; i++)
            {
                AddTokenNodes(array[i], string.Format("[{0}]", i), node.Nodes);
            }
        }

        private static void AddTokenNodes(JToken token, string name, TreeNodeCollection parent)
        {
            if (token is JValue value)
            {
                TreeNode mainChild = new TreeNode(name) { Tag = token.Path };
                mainChild.Nodes.Add(new TreeNode(value.Value.ToString()) { Tag = token.Path });
                // parent.Add(new TreeNode(string.Format("{0}: {1}", name, value.Value)));
                parent.Add(mainChild);
            }
            else if (token is JArray array)
            {
                AddArrayNodes(array, name, parent);
            }
            else if (token is JObject @object)
            {
                AddObjectNodes(@object, name, parent);
            }
        }
    }
}
