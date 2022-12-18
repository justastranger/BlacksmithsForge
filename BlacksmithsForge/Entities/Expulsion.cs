using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithsForge.Entities
{
    internal class Expulsion : IEntity
    {
        public JObject EntityData { get; set; }
        // For this Entity, the ID property determines the target
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
        public Guid Guid { get; set; } = new();
        public Dictionary<string, string>? Filter { get { return EntityData["filter"]?.ToObject<Dictionary<string, string>>(); } set => EntityData["filter"] = value != null ? JObject.FromObject(value) : null; }
        public int? Limit { get { return EntityData["limit"]?.ToObject<int>(); } set => EntityData["limit"] = value; }
        public string? ToPath { get { return EntityData["topath"]?.ToString(); } set => EntityData["topath"] = value; }

        public Expulsion(JObject entityData)
        {
            EntityData = entityData;
        }

    }
}
