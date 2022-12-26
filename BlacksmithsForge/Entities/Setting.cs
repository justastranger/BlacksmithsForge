using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithsForge.Entities
{
    public class Setting : IRootEntity
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
        public string? TabId { get { return EntityData["tabid"]?.ToString(); } set => EntityData["tabid"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Hint { get { return EntityData["hint"]?.ToString(); } set => EntityData["hint"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? HintLocId { get { return EntityData["hintlocid"]?.ToString(); } set => EntityData["hintlocid"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? MinValue { get { return EntityData["minvalue"]?.ToObject<int?>(); } set => EntityData["minvalue"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxValue { get { return EntityData["maxvalue"]?.ToObject<int?>(); } set => EntityData["maxvalue"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultValue { get { return EntityData["defaultvalue"]?.ToString(); } set => EntityData["defaultvalue"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? DataType { get { return EntityData["datatype"]?.ToString(); } set => EntityData["datatype"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string>? ValueLabels { get { return EntityData["valuelabels"]?.ToObject<Dictionary<string, string>?>(); } set => EntityData["valuelabels"] = value != null ? JObject.FromObject(value) : null; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string>? ValueInnerLabels { get { return EntityData["valueinnerlabels"]?.ToObject<Dictionary<string, string>?>(); } set => EntityData["valueinnerlabels"] = value != null ? JObject.FromObject(value) : null; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? TargetConfigArray { get { return EntityData["targetconfigarray"]?.ToString(); } set => EntityData["targetconfigarray"] = value; }



        public Setting(JObject entityData)
        {
            EntityData = entityData;
        }

        public Setting() : this(new())
        {

        }

        public override string ToString()
        {
            return Utils.ToJson(EntityData);
        }
    }
}
