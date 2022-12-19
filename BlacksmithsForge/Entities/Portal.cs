using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithsForge.Entities
{
    internal class Portal : IRootEntity
    {
        public JObject EntityData { get; set; }
        public string ID
        {
            get
            {
                if (EntityData["id"] == null) throw new NullReferenceException("Portal ID must be specified.");
                else return EntityData["id"].ToString();
            }
            set => EntityData["id"] = value;
        }
        public Guid Guid { get; set; } = new();
        public string? Filename { get; set; }

        public string? Label { get { return EntityData["label"]?.ToString(); } set => EntityData["label"] = value; }
        public string? Description { get { return EntityData["description"]?.ToString(); } set => EntityData["description"] = value; }
        public string? Icon { get { return EntityData["icon"]?.ToString(); } set => EntityData["icon"] = value; }
        public string? OtherworldId { get { return EntityData["otherworldid"]?.ToString(); } set => EntityData["otherworldid"] = value; }
        public string? EgressId { get { return EntityData["egressid"]?.ToString(); } set => EntityData["egressid"] = value; }
        public List<RecipeLink>? Consequences { get { return (List<RecipeLink>?)(EntityData["consequences"]?.Values<RecipeLink>()); } set => EntityData["consequences"] = value != null ? JArray.FromObject(value) : null; }



        public Portal(JObject entityData)
        {
            EntityData = entityData;
        }
    }
}
