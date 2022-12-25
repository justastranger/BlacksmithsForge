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
                if (EntityData["id"] == null) throw new NullReferenceException("Element ID must be specified.");
                else return EntityData["id"].ToString();
            }
            set => EntityData["id"] = value;
        }
        public Guid Guid { get; set; } = Guid.NewGuid();
        public string? Filename { get; set; }

        public string? TabId { get { return EntityData["tabid"]?.ToString(); } set => EntityData["tabid"] = value; }
        public string? Hint { get { return EntityData["hint"]?.ToString(); } set => EntityData["hint"] = value; }
        public string? HintLocId { get { return EntityData["hintlocid"]?.ToString(); } set => EntityData["hintlocid"] = value; }
        public int? MinValue { get { return EntityData["minvalue"]?.ToObject<int?>(); } set => EntityData["minvalue"] = value; }
        public int? MaxValue { get { return EntityData["maxvalue"]?.ToObject<int?>(); } set => EntityData["maxvalue"] = value; }
        public string? DefaultValue { get { return EntityData["defaultvalue"]?.ToString(); } set => EntityData["defaultvalue"] = value; }
        public string? DataType { get { return EntityData["datatype"]?.ToString(); } set => EntityData["datatype"] = value; }
        public Dictionary<string, string>? ValueLabels { get { return EntityData["valuelabels"]?.ToObject<Dictionary<string, string>?>(); } set => EntityData["valuelabels"] = value != null ? JObject.FromObject(value) : null; }
        public Dictionary<string, string>? ValueInnerLabels { get { return EntityData["valueinnerlabels"]?.ToObject<Dictionary<string, string>?>(); } set => EntityData["valueinnerlabels"] = value != null ? JObject.FromObject(value) : null; }
        public string? TargetConfigArray { get { return EntityData["targetconfigarray"]?.ToString(); } set => EntityData["targetconfigarray"] = value; }



        public Setting(JObject entityData)
        {
            EntityData = entityData;
        }

        public override string ToString()
        {
            return Utils.ToJson(this);
        }
    }
}
