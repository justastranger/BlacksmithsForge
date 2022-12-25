using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithsForge.Entities
{
    public class Element : IRootEntity
    {
        public JObject EntityData { get; set; }
        public string ID
        {
            get
            {
                if (EntityData["id"] == null) throw new NullReferenceException("Element ID must be specified.");
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
        public string? Icon { get { return EntityData["icon"]?.ToString(); } set => EntityData["icon"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? VerbIcon { get { return EntityData["verbicon"]?.ToString(); } set => EntityData["verbicon"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? DecayTo { get { return EntityData["decayto"]?.ToString(); } set => EntityData["decayto"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? BurnTo { get { return EntityData["burnto"]?.ToString(); } set => EntityData["burnto"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? DrownTo { get { return EntityData["drownto"]?.ToString(); } set => EntityData["drownto"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? UniquenessGroup { get { return EntityData["uniquenessgroup"]?.ToString(); } set => EntityData["uniquenessgroup"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? Resaturate { get { return EntityData["resaturate"]?.ToObject<bool?>(); } set => EntityData["resaturate"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAspect { get { return EntityData["isaspect"]?.ToObject<bool?>(); } set => EntityData["isaspect"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsHidden { get { return EntityData["ishidden"]?.ToObject<bool?>(); } set => EntityData["ishidden"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? NoArtNeeded { get { return EntityData["noartneeded"]?.ToObject<bool?>(); } set => EntityData["noartneeded"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Metafictional { get { return EntityData["metafictional"]?.ToString(); } set => EntityData["metafictional"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? ManifestationType { get { return EntityData["manifestationtype"]?.ToString(); } set => EntityData["manifestationtype"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<string>? Achievements { get { return (List<string>?)(EntityData["achievements"]?.Values<string>()); } set => EntityData["achievements"] = value != null ? JArray.FromObject(value) : null; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? Unique { get { return EntityData["unique"]?.ToObject<bool?>(); } set => EntityData["unique"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? Lifetime { get { return EntityData["lifetime"]?.ToObject<int?>(); } set => EntityData["lifetime"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Inherits { get { return EntityData["inherits"]?.ToString(); } set => EntityData["inherits"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, int>? Aspects { get { return EntityData["aspects"]?.ToObject<Dictionary<string, int>?>(); } set => EntityData["aspects"] = value != null ? JObject.FromObject(value) : null; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<string>? Commute { get { return (List<string>?)(EntityData["commute"]?.Values<string>()); } set => EntityData["commute"] = value != null ? JArray.FromObject(value) : null; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Sphere>? Slots { get { return (List<Sphere>?)(EntityData["slots"]?.Values<Sphere>()); } set => EntityData["slots"] = value != null ? JArray.FromObject(value) : null; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<RecipeLink>? Induces { get { return (List<RecipeLink>?)(EntityData["induces"]?.Values<RecipeLink>()); } set => EntityData["induces"] = value != null ? JArray.FromObject(value) : null; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, List<XTrigger>>? XTriggers { get { return EntityData["induces"]?.ToObject<Dictionary<string, List<XTrigger>>?>(); } set => EntityData["induces"] = value != null ? JObject.FromObject(value) : null; }


        public Element(JObject entityData)
        {
            EntityData = entityData;
        }

        public override string ToString()
        {
            return Utils.ToJson(this);
        }
    }
}
