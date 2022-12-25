using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithsForge.Entities
{
    public class EntityFactory
    {

        public static IEntityWithId Parse(JObject entityData, string type, string filename)
        {
            // get the right type name, hopefully not a big performance impact
            // would be easy enough to swap the strings in the switch below back to their plural form
            // type = Utils.PluralToSingular(type);

            return type switch
            {
                // the Filename is added only when Entities are parsed this way
                // 
                "achievements" => new Achievement(entityData) { Filename = filename },
                "cultures" => new Culture(entityData) { Filename = filename },
                "decks" => new Deck(entityData) { Filename = filename },
                "dicta" => new Dictum(entityData) { Filename = filename },
                "elements" => new Element(entityData) { Filename = filename },
                "endings" => new Ending(entityData) { Filename = filename },
                "legacies" => new Legacy(entityData) { Filename = filename },
                "levers" => new Lever(entityData) { Filename = filename },
                "portals" => new Portal(entityData) { Filename = filename },
                "recipes" => new Recipe(entityData) { Filename = filename },
                "settings" => new Setting(entityData) { Filename = filename },
                "verbs" => new Verb(entityData) { Filename = filename },
                _ => throw new NotImplementedException(),
            };
        }
    }
}
