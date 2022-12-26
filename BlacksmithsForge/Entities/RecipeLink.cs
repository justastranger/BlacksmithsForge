using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithsForge.Entities
{
    public class RecipeLink : IEntityWithId, ILink
    {
        public JObject EntityData { get; set; }
        // For this Entity, the ID property determines the target for the link
        // It should never be null
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

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? Chance { get { return EntityData["chance"]?.ToObject<int?>(); } set => EntityData["chance"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? Additional { get { return EntityData["additional"]?.ToObject<bool?>(); } set => EntityData["additional"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? ToPath { get { return EntityData["topath"]?.ToString(); } set => EntityData["topath"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string>? Challenges { get { return EntityData["challenges"]?.ToObject<Dictionary<string, string>?>(); } set => EntityData["challenges"] = value != null ? JObject.FromObject(value) : null; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Expulsion? Expulsion { get { return EntityData["expulsion"]?.ToObject<Expulsion?>(); } set => EntityData["expulsion"] = value != null ? JObject.FromObject(value) : null; }
        

        public RecipeLink(JObject entityData)
        {
            EntityData = entityData;
        }

        public RecipeLink(string id)
        {
            EntityData = new JObject();
            ID = id;
        }

        public Recipe? TryToRecipe()
        {
            // filter the EntityData
            List<JProperty> unknownProperties = Utils.GetUnknownProperties(EntityData, typeof(Recipe));
            
            JObject newEntityData = new(unknownProperties.ToArray());
            
            return newEntityData.ToObject<Recipe>();
        }

        public override string ToString()
        {
            return Utils.ToJson(EntityData);
        }
    }
}
