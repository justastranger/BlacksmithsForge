using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithsForge.Entities
{
    public class XTrigger : IEntityWithId
    {
        public JObject EntityData { get; set; }
        // determines result
        public string ID
        {
            get
            {
                if (EntityData["id"] == null) throw new NullReferenceException("XTrigger ID must be specified.");
                else return EntityData["id"].ToString();
            }
            set => EntityData["id"] = value;
        }
        public Guid Guid { get; set; } = Guid.NewGuid();

        public int? Chance { get { return EntityData["chance"]?.ToObject<int>(); } set => EntityData["chance"] = value; }
        public int? Level { get { return EntityData["level"]?.ToObject<int>(); } set => EntityData["level"] = value; }
        public string? MorphEffect { get { return EntityData["morpheffect"]?.ToString(); } set => EntityData["morpheffect"] = value; }




        public XTrigger(JObject entityData)
        {
            EntityData = entityData;
        }

        // anticipating quickspec support
        public XTrigger(string id)
        {
            EntityData = new();
            ID = id;
            Chance = 100;
            Level = 1;
            MorphEffect = "Transform";
        }
    }
}
