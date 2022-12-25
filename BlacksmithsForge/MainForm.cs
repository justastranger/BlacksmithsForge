using BlacksmithsForge.Editors;
using BlacksmithsForge.Entities;
using BlacksmithsForge.Mods;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BlacksmithsForge
{
    public partial class MainForm : Form
    {
        private Mod? CurrentMod;
        private Dictionary<Guid, IEntityWithId>? SelectedEntities;

        public MainForm()
        {
            InitializeComponent();
        }

        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentMod != null && MessageBox.Show("If you open a new folder, you will lose any unsaved progress. Are you sure?", "Mod Already Open", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                filesListView.Items.Clear();
                entitiesListView.Items.Clear();
                CurrentMod = null;
                SelectedEntities = null;

                string path = folderBrowserDialog.SelectedPath;
                try
                {
                    CurrentMod = new Mod(path);
                    DisplayContent();
                }
                catch (FileFormatException ffe)
                {
                    MessageBox.Show(ffe.Message, "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    // silently ignore exception from declining mod creation
                    if (!ex.Message.Contains("Declined"))
                    {
                        throw;
                    }
                }
            }
        }

        private void saveModToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentMod == null) return;

            SaveSynopsis();
            
            List<string> filenames = CurrentMod.Content.Keys.ToList();

            filenames.ForEach((string filename) =>
            {
                string type = CurrentMod.FileTypes[filename];
                JObject tmp = new()
                {
                    [type] = JArray.FromObject(CurrentMod.Content[filename].Values.ToList().Select((entity) => { return entity.EntityData; }))
                };

                string fullPath = Path.Combine(CurrentMod.RootPath, "content") + filename;

                using StreamWriter writer = File.CreateText(fullPath);
                writer.Write(tmp.ToString());
                writer.Flush();

            });

        }

        private void SaveSynopsis()
        {
            if (CurrentMod == null)
            {
                throw new NullReferenceException("Saving should not have been able to start while CurrentMod is null.");
            }
            string synopsisText = JsonConvert.SerializeObject(CurrentMod?.Synopsis, new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore,
                Formatting = Formatting.Indented
            });
            // VS shows a possible null reference but it's guarded against up above
            // a Mod can't be constructed without having a SynopsisPath computed for it anyways
            using StreamWriter streamWriter = File.CreateText(CurrentMod?.SynopsisPath);
            streamWriter.Write(synopsisText);
            streamWriter.Flush();
        }

        private void DisplayContent()
        {
            if (CurrentMod == null) 
            {
                filesListView.Items.Clear();
                entitiesListView.Items.Clear();
                return;
            }

            CurrentMod.Content.Keys.ToList().ForEach((string file) => {
                filesListView.Items.Add(file);

            });
        }

        private void UpdateEntities()
        {
            entitiesListView.Items.Clear();
            if (SelectedEntities == null) return;

            List<ListViewItem> items = new();
            foreach (KeyValuePair<Guid, IEntityWithId> pair in SelectedEntities)
            {
                ListViewItem item = new(pair.Value.ID) { Tag = pair.Key };
                items.Add(item);
            }
            entitiesListView.Items.AddRange(items.ToArray());
        }

        private void UpdateFilesList()
        {
            filesListView.Items.Clear();
            if (CurrentMod != null)
            {
                CurrentMod.Content.Keys.ToList().ForEach((string file) => {
                    filesListView.Items.Add(file);
                });
            }

        }

        private void editSynopsisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentMod?.Synopsis != null)
            {
                SynopsisEditor synopsisEditor = new(ref CurrentMod.Synopsis);
                synopsisEditor.Show();
            }
        }

        private void filesListView_DoubleClick(object sender, EventArgs e)
        {
            if (CurrentMod == null) return;
            if (filesListView.SelectedItems.Count != 1) return;
            
            entitiesListView.Items.Clear();

            string filename = filesListView.SelectedItems[0].Text;

            fileTypeLabel.Text = CurrentMod.FileTypes[filename];
            SelectedEntities = CurrentMod.Content[filename];

            List<ListViewItem> items = new();
            foreach (KeyValuePair<Guid, IEntityWithId> pair in SelectedEntities)
            {
                ListViewItem item = new(pair.Value.ID) { Tag = pair.Key };
                items.Add(item);
            }
            entitiesListView.Items.AddRange(items.ToArray());
        }

        // "Disabled" double clicking until I figure out the best thing to do when you do so
        private void entitiesListView_DoubleClick(object sender, EventArgs e)
        {
            //if (CurrentMod == null) return;
            //if (SelectedEntities == null) return;
            //if (entitiesListView.SelectedItems.Count != 1) return;

            //Guid selectedGuid = (Guid)entitiesListView.SelectedItems[0].Tag;
            //IEntity selectedEntity = SelectedEntities[selectedGuid];

            //// Serialize EntityData and slap it into the editor
            //JsonTextEditor jsonEditor = new(selectedEntity.EntityData.ToString());
            //// and if the Accept button is pressed
            //if (jsonEditor.ShowDialog() == DialogResult.Yes)
            //{
            //    // we deserialize the EntityData and replace the old with the new
            //    selectedEntity.EntityData = JObject.Parse(jsonEditor.jsonText);
            //}
        }

        private void jsonTextEditorButton_Click(object sender, EventArgs e)
        {
            if (CurrentMod == null) return;
            if (SelectedEntities == null) return;
            if (entitiesListView.SelectedItems.Count != 1) return;

            Guid selectedGuid = (Guid)entitiesListView.SelectedItems[0].Tag;
            IEntityWithId selectedEntity = SelectedEntities[selectedGuid];

            // Serialize EntityData and slap it into the editor
            JsonTextEditor jsonEditor = new(selectedEntity.EntityData.ToString());
            // and if the Accept button is pressed
            if (jsonEditor.ShowDialog() == DialogResult.Yes)
            {
                // we deserialize the EntityData and replace the old with the new
                selectedEntity.EntityData = JObject.Parse(jsonEditor.jsonText);
                UpdateEntities();
            }
        }

        private void jsonTreeViewEditorButton_Click(object sender, EventArgs e)
        {
            if (CurrentMod == null) return;
            if (SelectedEntities == null) return;
            if (entitiesListView.SelectedItems.Count != 1) return;

            Guid selectedGuid = (Guid)entitiesListView.SelectedItems[0].Tag;
            IEntityWithId selectedEntity = SelectedEntities[selectedGuid];

            // Whip up a TreeViewEditor with the selected EntityData
            JsonTreeViewEditor jsonEditor = new(selectedEntity.EntityData);
            // and if the Accept button is pressed
            jsonEditor.ShowDialog();
            UpdateEntities();
        }
    }
}