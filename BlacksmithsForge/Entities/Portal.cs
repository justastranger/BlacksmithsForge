using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithsForge.Entities
{
    public class Portal : IRootEntity
    {
        public JObject EntityData { get; set; }
        public string ID
        {
            get
            {
                if (EntityData["id"] == null) return "";
                else return EntityData["id"].ToString();
            }
            set => EntityData["id"] = value;
        }
        public Guid Guid { get; set; } = Guid.NewGuid();
        public string? Filename { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Label { get { return EntityData["label"]?.ToString(); } set => EntityData["label"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Description { get { return EntityData["description"]?.ToString(); } set => EntityData["description"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Icon { get { return EntityData["icon"]?.ToString(); } set => EntityData["icon"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? OtherworldId { get { return EntityData["otherworldid"]?.ToString(); } set => EntityData["otherworldid"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? EgressId { get { return EntityData["egressid"]?.ToString(); } set => EntityData["egressid"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<RecipeLink>? Consequences { get { return (List<RecipeLink>?)(EntityData["consequences"]?.Values<RecipeLink>()); } set => EntityData["consequences"] = value != null ? JArray.FromObject(value) : null; }



        public Portal(JObject entityData)
        {
            EntityData = entityData;
        }

        public override string ToString()
        {
            return Utils.ToJson(EntityData);
        }
    }
}
