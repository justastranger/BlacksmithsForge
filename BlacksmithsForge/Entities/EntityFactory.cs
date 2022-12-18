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
            switch (type)
            {
                case "elements":
                    return new Element(entityData);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
