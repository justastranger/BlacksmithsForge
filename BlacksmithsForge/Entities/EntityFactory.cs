using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithsForge.Entities
{
    internal class EntityFactory
    {

        public static IEntity Parse(JObject entityData, string type, string filename)
        {
            // get the right type name, hopefully not a big performance impact
            // would be easy enough to swap the strings in the switch below back to their plural form
            type = Utils.PluralToSingular(type);

            return type switch
            {
                "achievement" => throw new NotImplementedException(),
                "culture" => throw new NotImplementedException(),
                "deck" => new Deck(entityData) { Filename = filename },
                "element" => new Element(entityData) { Filename = filename },
                "ending" => new Ending(entityData) { Filename = filename },
                "legacy" => new Legacy(entityData) { Filename = filename },
                "lever" => new Lever(entityData) { Filename = filename },
                "portal" => new Portal(entityData) { Filename = filename },
                "recipe" => new Recipe(entityData) { Filename = filename },
                "setting" => throw new NotImplementedException(),
                "verb" => new Verb(entityData) { Filename = filename },
                _ => throw new NotImplementedException(),
            };
        }
    }
}
