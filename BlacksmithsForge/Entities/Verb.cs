using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithsForge.Entities
{
    public class Verb : IRootEntity
    {
        public JObject EntityData { get; set; }
        public string ID
        {
            get
            {
                if (EntityData["id"] == null) throw new NullReferenceException("Verb ID must be specified.");
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
        public bool? Directable { get { return EntityData["directable"]?.ToObject<bool?>(); } set => EntityData["directable"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Category { get { return EntityData["category"]?.ToString(); } set => EntityData["category"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? Spontaneous { get { return EntityData["spontaneous"]?.ToObject<bool?>(); } set => EntityData["spontaneous"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Sphere? Slot { get { return EntityData["slot"]?.ToObject<Sphere?>(); } set => EntityData["slot"] = value != null ? JObject.FromObject(value) : null; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Sphere>? Slots { get { return (List<Sphere>?)(EntityData["slots"]?.Values<Sphere>()); } set => EntityData["slots"] = value != null ? JArray.FromObject(value) : null; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, int>? Aspects { get { return EntityData["aspects"]?.ToObject<Dictionary<string, int>?>(); } set => EntityData["aspects"] = value != null ? JObject.FromObject(value) : null; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, List<XTrigger>>? XTriggers { get { return EntityData["induces"]?.ToObject<Dictionary<string, List<XTrigger>>?>(); } set => EntityData["induces"] = value != null ? JObject.FromObject(value) : null; }



        public Verb(JObject entityData)
        {
            EntityData = entityData;
        }

        public override string ToString()
        {
            return Utils.ToJson(this);
        }
    }
}
