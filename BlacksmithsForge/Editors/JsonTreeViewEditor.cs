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
    }
}
