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
                if (EntityData["id"] == null) throw new NullReferenceException("Element ID must be specified.");
                else return EntityData["id"].ToString();
            }
            set => EntityData["id"] = value;
        }
        public Guid Guid { get; set; } = Guid.NewGuid();
        public string? Filename { get; set; }

        public string? Endonym { get { return EntityData["endonym"]?.ToString(); } set => EntityData["endonym"] = value; }
        public string? Exonym { get { return EntityData["exonym"]?.ToString(); } set => EntityData["exonym"] = value; }
        public string? FontScript { get { return EntityData["fontscript"]?.ToString(); } set => EntityData["fontscript"] = value; }
        public bool? BoldAllowed { get { return EntityData["boldallowed"]?.ToObject<bool?>(); } set => EntityData["boldallowed"] = value; }
        public bool? Released { get { return EntityData["released"]?.ToObject<bool?>(); } set => EntityData["released"] = value; }
        public Dictionary<string, string>? UILabels { get { return EntityData["uilabels"]?.ToObject<Dictionary<string, string>?>(); } set => EntityData["uilabels"] = value != null ? JObject.FromObject(value) : null; }


        public Culture(JObject entityData)
        {
            EntityData = entityData;
        }

        public override string ToString()
        {
            return Utils.ToJson(this);
        }
    }
}
