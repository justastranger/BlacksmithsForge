using BlacksmithsForge.Editors;
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
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string path = folderBrowserDialog.SelectedPath;
                try
                {
                    CurrentMod = new Mod(path);
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
            // VS shows a possible null reference but it's guarded against up top
            // a Mod can't be constructed without having a SynopsisPath computed for it anyways
            using StreamWriter streamWriter = File.CreateText(CurrentMod?.SynopsisPath);
            streamWriter.Write(synopsisText);
        }

        private void editSynopsisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentMod?.Synopsis != null)
            {
                SynopsisEditor synopsisEditor = new(ref CurrentMod.Synopsis);
                synopsisEditor.Show();
            }
        }
    }
}