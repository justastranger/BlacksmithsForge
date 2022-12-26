using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithsForge.Entities
{
    public class Culture : IRootEntity
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
        public string? Endonym { get { return EntityData["endonym"]?.ToString(); } set => EntityData["endonym"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Exonym { get { return EntityData["exonym"]?.ToString(); } set => EntityData["exonym"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? FontScript { get { return EntityData["fontscript"]?.ToString(); } set => EntityData["fontscript"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? BoldAllowed { get { return EntityData["boldallowed"]?.ToObject<bool?>(); } set => EntityData["boldallowed"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? Released { get { return EntityData["released"]?.ToObject<bool?>(); } set => EntityData["released"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string>? UILabels { get { return EntityData["uilabels"]?.ToObject<Dictionary<string, string>?>(); } set => EntityData["uilabels"] = value != null ? JObject.FromObject(value) : null; }


        public Culture(JObject entityData)
        {
            EntityData = entityData;
        }

        public Culture() : this(new())
        {

        }

        public override string ToString()
        {
            return Utils.ToJson(EntityData);
        }
    }
}
