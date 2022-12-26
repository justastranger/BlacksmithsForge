using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithsForge.Entities
{
    public class Deck : IRootEntity
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
        public string? Comments { get { return EntityData["comments"]?.ToString(); } set => EntityData["comments"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Cover { get { return EntityData["cover"]?.ToString(); } set => EntityData["cover"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultCard { get { return EntityData["defaultcard"]?.ToString(); } set => EntityData["defaultcard"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsHidden { get { return EntityData["ishidden"]?.ToObject<bool?>(); } set => EntityData["ishidden"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? ResetOnExhaustion { get { return EntityData["resetonexhaustion"]?.ToObject<bool?>(); } set => EntityData["resetonexhaustion"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? Draws { get { return EntityData["draws"]?.ToObject<int>() ?? 1; } set => EntityData["draws"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<string>? Spec { get { return (List<string>?)(EntityData["spec"]?.Values<string>()); } set => EntityData["spec"] = value != null ? JArray.FromObject(value) : null; }


        public Deck(JObject entityData)
        {
            EntityData = entityData;
        }

        public Deck() : this(new())
        {

        }

        public override string ToString()
        {
            return Utils.ToJson(EntityData);
        }
    }
}
