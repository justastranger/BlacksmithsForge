using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithsForge.Entities
{
    public class Ending : IRootEntity
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
        public string? Image { get { return EntityData["image"]?.ToString(); } set => EntityData["image"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Flavour { get { return EntityData["flavour"]?.ToString() ?? "melancholy"; } set => EntityData["flavour"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Anim { get { return EntityData["anim"]?.ToString(); } set => EntityData["anim"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<string>? Achievements { get { return (List<string>?)(EntityData["achievements"]?.Values<string>()); } set => EntityData["achievements"] = value != null ? JArray.FromObject(value) : null; }

        public Ending(JObject entityData)
        {
            EntityData = entityData;
        }

        public override string ToString()
        {
            return Utils.ToJson(EntityData);
        }

    }
}
