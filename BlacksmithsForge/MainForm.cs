using BlacksmithsForge.Editors;
using BlacksmithsForge.Entities;
using BlacksmithsForge.Mods;
using Newtonsoft.Json;

namespace BlacksmithsForge
{
    public partial class MainForm : Form
    {
        private Mod? CurrentMod;

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
            if (CurrentMod != null)
            {
                SaveSynopsis();
            }

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
            if (filesListView.SelectedItems.Count == 0) return;
            
            entitiesListView.Items.Clear();

            string filename = filesListView.SelectedItems[0].Text;

            fileTypeLabel.Text = CurrentMod.FileTypes[filename];
            Dictionary<Guid, IEntity> selectedEntities = CurrentMod.Content[filename];

            List<ListViewItem> items = new();
            foreach (KeyValuePair<Guid, IEntity> pair in selectedEntities)
            {
                ListViewItem item = new(pair.Value.ID) { Tag = pair.Key };
                items.Add(item);
            }
            entitiesListView.Items.AddRange(items.ToArray());
        }
    }
}