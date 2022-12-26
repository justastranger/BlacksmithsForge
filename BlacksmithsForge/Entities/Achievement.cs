using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithsForge.Entities
{
    public class Achievement : IRootEntity
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
        public string? DescriptionLocked { get { return EntityData["descriptionlocked"]?.ToString(); } set => EntityData["descriptionlocked"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? DescriptionUnlocked { get { return EntityData["descriptionunlocked"]?.ToString(); } set => EntityData["descriptionunlocked"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? SingleDescription { get { return EntityData["singledescription"]?.ToObject<bool?>(); } set => EntityData["singledescription"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? IconUnlocked { get { return EntityData["iconunlocked"]?.ToString(); } set => EntityData["iconunlocked"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? IconLocked { get { return EntityData["iconlocked"]?.ToString(); } set => EntityData["iconlocked"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? UnlockMessage { get { return EntityData["unlockmessage"]?.ToString(); } set => EntityData["unlockmessage"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsHidden { get { return EntityData["ishidden"]?.ToObject<bool?>(); } set => EntityData["ishidden"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCategory { get { return EntityData["iscategory"]?.ToObject<bool?>(); } set => EntityData["iscategory"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Category { get { return EntityData["category"]?.ToString(); } set => EntityData["category"] = value; }
        // should basically always be false for custom achievements
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? ValidateOnStorefront { get { return EntityData["validateonstorefront"]?.ToObject<bool?>(); } set => EntityData["validateonstorefront"] = value; }



        public Achievement(JObject entityData)
        {
            EntityData = entityData;
        }

        public Achievement() : this(new())
        {

        }

        public override string ToString()
        {
            return Utils.ToJson(EntityData);
        }
    }
}
