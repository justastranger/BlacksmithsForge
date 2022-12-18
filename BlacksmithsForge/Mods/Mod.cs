using BlacksmithsForge.Editors;
using BlacksmithsForge.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
        public string RootPath;
        public Synopsis? Synopsis;
        public string SynopsisPath;

        public Dictionary<string, Dictionary<string, IEntity>> Content = new();

        public Mod(string path)
        {
            RootPath = path;
            SynopsisPath = Path.Combine(path, "synopsis.json");

            // initialize the mod, basically
            LoadOrCreateSynopsis();
            // 
            LoadContent();
        }

        private void LoadOrCreateSynopsis()
        {
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

        private void LoadContent()
        {
            string contentFolder = Path.Combine(RootPath, "content");

            // If content folder doesn't exist, create it.
            // This code should only be reached if a synopsis is correctly loaded or created
            if (!Directory.Exists(contentFolder))
            {
                Directory.CreateDirectory(contentFolder);
            }

            // Gather the json files in the content folder
            List<string> files = Directory.EnumerateFiles(contentFolder, "*.json").ToList();
            // Guard check to end early
            if (files.Count == 0) return;

            files.ForEach((string file) => {
                string json = File.OpenText(file).ReadToEnd();
                // All valid CS JSON exist as a main object with only one property
                // That property's value is an Array of Entities whose key is the type being loaded
                JObject parsedJson = JObject.Parse(json);
                string jsonType = parsedJson.Properties().First().Name;
                // TODO decide how to handle loading
                // Perhaps a switch/case with Entities whose constructor is just the JObject?
                // Could use that and properties whose getters pull out of the JObject instance (with null checks)
                // CSpark used a switch/case that did some type-specific pre-processing in order to convert from quickspec format

            });
        }
    }
}
