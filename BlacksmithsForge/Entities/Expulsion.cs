using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithsForge.Entities
{
    public class Expulsion : IEntity
    {
        public JObject EntityData { get; set; }
        // For this Entity, the ID property determines the target
        // It should never be null
        public Guid Guid { get; set; } = Guid.NewGuid();


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string>? Filter { get { return EntityData["filter"]?.ToObject<Dictionary<string, string>>(); } set => EntityData["filter"] = value != null ? JObject.FromObject(value) : null; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get { return EntityData["limit"]?.ToObject<int?>(); } set => EntityData["limit"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? ToPath { get { return EntityData["topath"]?.ToString(); } set => EntityData["topath"] = value; }

        public Expulsion(JObject entityData)
        {
            EntityData = entityData;
        }

        public Expulsion() : this(new())
        {

        }

        public override string ToString()
        {
            return Utils.ToJson(EntityData);
        }
    }
}
