using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithsForge
{
    internal class Utils
    {
        public static string PluralToSingular(string name) {
            switch (name)
            {
                case "achievements": return "achievement";
                case "cultures": return "culture";
                case "decks": return "deck";
                case "elements": return "element";
                case "endings": return "ending";
                case "legacies": return "legacy";
                case "levers": return "lever";
                case "portals": return "portal";
                case "recipes": return "recipe";
                case "settings": return "setting";
                case "verbs": return "verb";
                default: return "unknown";
            }
        }
    }
}
