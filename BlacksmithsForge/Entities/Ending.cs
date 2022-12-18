using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithsForge.Entities
{
    internal class Ending : IEntity
    {
        public JObject EntityData { get; set; }
        public string ID { get; set; }
        public Guid Guid { get; set; } = new();

        public string? Label { get { return EntityData["label"]?.ToString(); } set => EntityData["label"] = value; }
        public string? Description { get { return EntityData["description"]?.ToString(); } set => EntityData["description"] = value; }
        public string? Comments { get { return EntityData["comments"]?.ToString(); } set => EntityData["comments"] = value; }
        public string? Image { get { return EntityData["image"]?.ToString(); } set => EntityData["image"] = value; }
        public string? Flavour { get { return EntityData["flavour"]?.ToString() ?? "melancholy"; } set => EntityData["flavour"] = value; }
        public string? Anim { get { return EntityData["anim"]?.ToString(); } set => EntityData["anim"] = value; }
        public List<string>? Achievements { get { return (List<string>?)(EntityData["achievements"]?.Values<string>()); } set => EntityData["achievements"] = value != null ? JArray.FromObject(value) : null; }


        public Ending(JObject entityData)
        {
            EntityData = entityData;
            if (entityData["id"] is not JToken id)
            {
                throw new Exception("Ending without an ID encountered");
            }
            else
            {
                ID = id.ToString();
            }
        }


    }
}
