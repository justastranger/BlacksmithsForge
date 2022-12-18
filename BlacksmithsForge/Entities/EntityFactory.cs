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

        public static IEntity Parse(JObject entityData, string type)
        {
            // get the right type name, hopefully not a big performance impact
            // would be easy enough to swap the strings in the switch below back to their plural form
            type = Utils.PluralToSingular(type);

            return type switch
            {
                "achievement" => throw new NotImplementedException(),
                "culture" => throw new NotImplementedException(),
                "deck" => throw new NotImplementedException(),
                "element" => new Element(entityData),
                "ending" => throw new NotImplementedException(),
                "legacy" => throw new NotImplementedException(),
                "lever" => throw new NotImplementedException(),
                "portal" => throw new NotImplementedException(),
                "recipe" => throw new NotImplementedException(),
                "setting" => throw new NotImplementedException(),
                "verb" => throw new NotImplementedException(),
                _ => throw new NotImplementedException(),
            };
        }
    }
}
