using BlacksmithsForge.Editors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithsForge.Mods
{
    public class Mod
    {
        public string? Name;
        public string Filepath;
        public Synopsis? Synopsis;
        public string SynopsisPath;

        public Mod(string path)
        {
            Filepath = path;
            SynopsisPath = Path.Combine(path, "synopsis.json");

            // check to see if path leads to a valid mod
            if (!File.Exists(SynopsisPath))
            {
                // ask user if they want to create a synopsis
                if (MessageBox.Show("There was no synopsis detected (or it was corrupted), would you like to create one?", "Create Mod?", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    // if they decline, interrupt Mod construction
                    // handle this silently where the Mod is constructed, simply discarding the work done up till here
                    throw new Exception("New Mod Creation Declined");
                }
                else
                {
                    // empty Synopsis
                    Synopsis = new();
                    // The newly-minted Synopsis above is passed via reference below for modification
                    // Passing values by reference means they don't need to be passed back after editing for changes to be shown
                    SynopsisEditor synopsisEditor = new(ref Synopsis);
                    // use Show to block the rest of the application until you finish with the Synopsis
                    synopsisEditor.Show();
                }
            }
            else
            {
                // attempt to deserialize Synopsis if detected, ignoring null values
                Synopsis = JsonConvert.DeserializeObject<Synopsis>(File.OpenText(SynopsisPath).ReadToEnd(), new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });
                if (Synopsis == null)
                {
                    // This should only be possible if the file is corrupted
                    throw new FileFormatException("Something is wrong with synopsis.json, check to make sure it's not corrupted");
                }
                else
                {
                    // update display name of mod
                    Name = Synopsis.Name;
                }
            }
        }
    }
}
