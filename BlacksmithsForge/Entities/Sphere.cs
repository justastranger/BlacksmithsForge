using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithsForge.Entities
{
    // aka Slot
    public class Sphere : IEntityWithId
    {
        public JObject EntityData { get; set; }
        public string ID
        {
            get
            {
                if (EntityData["id"] == null) throw new NullReferenceException("Sphere ID must be specified.");
                else return EntityData["id"].ToString();
            }
            set => EntityData["id"] = value;
        }
        public Guid Guid { get; set; } = Guid.NewGuid();

        public string? Label { get { return EntityData["label"]?.ToString(); } set => EntityData["label"] = value; }
        public string? Description { get { return EntityData["description"]?.ToString(); } set => EntityData["description"] = value; }
        public string? ActionId { get { return EntityData["actionid"]?.ToString(); } set => EntityData["actionid"] = value; }
        public Dictionary<string, int>? Essential { get { return EntityData["essential"]?.ToObject<Dictionary<string, int>?>(); } set => EntityData["essential"] = value != null ? JObject.FromObject(value) : null; }
        public Dictionary<string, int>? Required { get { return EntityData["required"]?.ToObject<Dictionary<string, int>?>(); } set => EntityData["required"] = value != null ? JObject.FromObject(value) : null; }
        public Dictionary<string, int>? Forbidden { get { return EntityData["forbidden"]?.ToObject<Dictionary<string, int>?>(); } set => EntityData["forbidden"] = value != null ? JObject.FromObject(value) : null; }
        public Dictionary<string, string>? IfAspectsPresent { get { return EntityData["ifaspectspresent"]?.ToObject<Dictionary<string, string>?>(); } set => EntityData["ifaspectspresent"] = value != null ? JObject.FromObject(value) : null; }
        public bool? Greedy { get { return EntityData["greedy"]?.ToObject<bool?>(); } set => EntityData["greedy"] = value; }
        public bool? Consumes { get { return EntityData["consumes"]?.ToObject<bool?>(); } set => EntityData["consumes"] = value; }
        public List<Angel>? Angels { get { return (List<Angel>?)(EntityData["angels"]?.Values<Angel>()); } set => EntityData["angels"] = value != null ? JArray.FromObject(value) : null; }
        public string? FromPath { get { return EntityData["frompath"]?.ToString(); } set => EntityData["frompath"] = value; }
        public string? EnRouteSpherePath { get { return EntityData["enroutespherepath"]?.ToString(); } set => EntityData["enroutespherepath"] = value; }
        public string? WindowsSpherePath { get { return EntityData["windowsspherepath"]?.ToString(); } set => EntityData["windowsspherepath"] = value; }



        public Sphere(JObject entityData)
        {
            EntityData = entityData;
        }

        public override string ToString()
        {
            return EntityData.ToString();
        }
    }
}
