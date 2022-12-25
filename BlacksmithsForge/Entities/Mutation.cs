using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithsForge.Entities
{
    public class Mutation : IEntityWithId
    {
        public JObject EntityData { get; set; }
        public string ID
        {
            get
            {
                if (EntityData["id"] == null) throw new NullReferenceException("Mutation ID must be specified.");
                else return EntityData["id"].ToString();
            }
            set => EntityData["id"] = value;
        }
        public Guid Guid { get; set; } = Guid.NewGuid();

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Filter { get { return EntityData["filter"]?.ToString(); } set => EntityData["filter"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Mutate { get { return EntityData["mutate"]?.ToString(); } set => EntityData["mutate"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? Level { get { return EntityData["level"]?.ToObject<int?>(); } set => EntityData["level"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? Additive { get { return EntityData["additive"]?.ToObject<bool?>(); } set => EntityData["additive"] = value; }



        public Mutation(JObject entityData)
        {
            EntityData = entityData;
        }

        public override string ToString()
        {
            return Utils.ToJson(EntityData);
        }
    }
}
