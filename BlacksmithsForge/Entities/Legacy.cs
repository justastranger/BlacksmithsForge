using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithsForge.Entities
{
    public class Legacy : IRootEntity
    {
        public JObject EntityData { get; set; }
        public string ID
        {
            get
            {
                if (EntityData["id"] == null) throw new NullReferenceException("Legacy ID must be specified.");
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
        public string? StartDescription { get { return EntityData["startdescription"]?.ToString(); } set => EntityData["startdescription"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Image { get { return EntityData["image"]?.ToString(); } set => EntityData["image"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Family { get { return EntityData["family"]?.ToString(); } set => EntityData["family"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? TableCoverImage { get { return EntityData["tablecoverimage"]?.ToString(); } set => EntityData["tablecoverimage"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? TableSurfaceImage { get { return EntityData["tablesurfaceimage"]?.ToString(); } set => EntityData["tablesurfaceimage"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? TableEdgeImage { get { return EntityData["tableedgeimage"]?.ToString(); } set => EntityData["tableedgeimage"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? FromEnding { get { return EntityData["fromending"]?.ToString(); } set => EntityData["fromending"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? AvailableWithoutEndingMatch { get { return EntityData["availablewithoutendingmatch"]?.ToObject<bool?>(); } set => EntityData["availablewithoutendingmatch"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewStart { get { return EntityData["newstart"]?.ToObject<bool?>(); } set => EntityData["newstart"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, int>? Effects { get { return EntityData["effects"]?.ToObject<Dictionary<string, int>?>(); } set => EntityData["effects"] = value != null ? JObject.FromObject(value) : null; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<RecipeLink>? Startup { get { return (List<RecipeLink>?)(EntityData["startup"]?.Values<RecipeLink>()); } set => EntityData["startup"] = value != null ? JArray.FromObject(value) : null; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<string>? ExcludesOnEnding { get { return (List<string>?)(EntityData["excludesonending"]?.Values<string>()); } set => EntityData["excludesonending"] = value != null ? JArray.FromObject(value) : null; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<string>? StatusBarElements { get { return (List<string>?)(EntityData["statusbarelements"]?.Values<string>()); } set => EntityData["statusbarelements"] = value != null ? JArray.FromObject(value) : null; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? StartingVerbId { get { return EntityData["startingverbid"]?.ToString(); } set => EntityData["startingverbid"] = value; }



        public Legacy(JObject entityData)
        {
            EntityData = entityData;
        }

        public override string ToString()
        {
            return Utils.ToJson(this);
        }
    }
}
