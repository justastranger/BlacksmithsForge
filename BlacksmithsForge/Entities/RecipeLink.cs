using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithsForge.Entities
{
    internal class RecipeLink : IEntity
    {
        public JObject EntityData { get; set; }
        // For this Entity, the ID property determines the target for the link
        // It should never be null
        public string ID
        {
            get
            {
                if (EntityData["id"] == null) throw new NullReferenceException("RecipeLink ID must be specified.");
                else return EntityData["id"].ToString();
            }
            set => EntityData["id"] = value;
        }
        public Guid Guid { get; set; } = Guid.NewGuid()

        public int? Chance { get { return EntityData["chance"]?.ToObject<int>(); } set => EntityData["chance"] = value; }
        public bool? Additional { get { return EntityData["additional"]?.ToObject<bool>(); } set => EntityData["additional"] = value; }
        public string? ToPath { get { return EntityData["topath"]?.ToString(); } set => EntityData["topath"] = value; }
        public Dictionary<string, string>? Challenges { get { return EntityData["challenges"]?.ToObject<Dictionary<string, string>>(); } set => EntityData["challenges"] = value != null ? JObject.FromObject(value) : null; }
        public Expulsion? Expulsion { get { return EntityData["challenges"]?.ToObject<Expulsion>(); } set => EntityData["challenges"] = value != null ? JObject.FromObject(value) : null; }
        

        public RecipeLink(JObject entityData)
        {
            EntityData = entityData;
        }
    }
}
