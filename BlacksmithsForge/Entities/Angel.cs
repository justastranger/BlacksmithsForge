using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithsForge.Entities
{
    public class Angel : IEntityWithId
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

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Choir { get { return EntityData["choir"]?.ToString(); } set => EntityData["choir"] = value; }
        // reference to a Sphere's ID
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? LiveIn { get { return EntityData["livein"]?.ToString(); } set => EntityData["livein"] = value; }
        // reference to a Sphere's ID
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? WatchOver { get { return EntityData["watchover"]?.ToString(); } set => EntityData["watchover"] = value; }


        public Angel(JObject entityData)
        {
            EntityData = entityData;
        }

        public Angel() : this(new())
        {

        }

        public override string ToString()
        {
            return Utils.ToJson(EntityData);
        }
    }
}
