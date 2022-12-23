using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithsForge.Entities
{
    public class Mutation : IEntity
    {
        public JObject EntityData { get; set; }
        public string ID
        {
            get
            {
                if (EntityData["id"] == null) throw new NullReferenceException("Mutation ID must be specified.");
                else return EntityData["id"].ToString();
            }
            set => EntityData["id"] = value;
        }
        public Guid Guid { get; set; } = Guid.NewGuid();
        public string? Filter { get { return EntityData["filter"]?.ToString(); } set => EntityData["filter"] = value; }
        public string? Mutate { get { return EntityData["mutate"]?.ToString(); } set => EntityData["mutate"] = value; }
        public int? Level { get { return EntityData["level"]?.ToObject<int>(); } set => EntityData["level"] = value; }
        public bool? Additive { get { return EntityData["additive"]?.ToObject<bool>(); } set => EntityData["additive"] = value; }



        public Mutation(JObject entityData)
        {
            EntityData = entityData;
        }
    }
}
