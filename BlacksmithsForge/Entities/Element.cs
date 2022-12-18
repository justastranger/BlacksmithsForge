using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithsForge.Entities
{
    internal class Element : IEntity
    {
        public JObject EntityData { get; set; }
        public string ID { get; set; }
        public Guid Guid { get; set; } = new();


        public string? Label { get { return EntityData["label"]?.ToString(); } set => EntityData["label"] = value; }
        public string? Description { get { return EntityData["description"]?.ToString(); } set => EntityData["description"] = value; }
        public string? Comments { get { return EntityData["comments"]?.ToString(); } set => EntityData["comments"] = value; }
        public string? Icon { get { return EntityData["icon"]?.ToString(); } set => EntityData["icon"] = value; }
        public string? VerbIcon { get { return EntityData["verbicon"]?.ToString(); } set => EntityData["verbicon"] = value; }
        public string? DecayTo { get { return EntityData["decayto"]?.ToString(); } set => EntityData["decayto"] = value; }
        public string? BurnTo { get { return EntityData["burnto"]?.ToString(); } set => EntityData["burnto"] = value; }
        public string? DrownTo { get { return EntityData["drownto"]?.ToString(); } set => EntityData["drownto"] = value; }
        public string? UniquenessGroup { get { return EntityData["uniquenessgroup"]?.ToString(); } set => EntityData["uniquenessgroup"] = value; }
        public bool? Resaturate { get { return EntityData["resaturate"]?.ToObject<bool>(); } set => EntityData["resaturate"] = value; }
        public bool? IsAspect { get { return EntityData["isaspect"]?.ToObject<bool>(); } set => EntityData["isaspect"] = value; }
        public bool? IsHidden { get { return EntityData["ishidden"]?.ToObject<bool>(); } set => EntityData["ishidden"] = value; }
        public bool? NoArtNeeded { get { return EntityData["noartneeded"]?.ToObject<bool>(); } set => EntityData["noartneeded"] = value; }
        public string? Metafictional { get { return EntityData["metafictional"]?.ToString(); } set => EntityData["metafictional"] = value; }
        public string? ManifestationType { get { return EntityData["manifestationtype"]?.ToString(); } set => EntityData["manifestationtype"] = value; }
        public List<string>? Achievements { get { return (List<string>?)(EntityData["achievements"]?.Values<string>()); } set => EntityData["achievements"] = value != null ? JArray.FromObject(value) : null; }
        public bool? Unique { get { return EntityData["unique"]?.ToObject<bool>(); } set => EntityData["unique"] = value; }
        public int? Lifetime { get { return EntityData["lifetime"]?.ToObject<int>(); } set => EntityData["lifetime"] = value; }
        public string? Inherits { get { return EntityData["inherits"]?.ToString(); } set => EntityData["inherits"] = value; }
        public Dictionary<string, int>? Aspects { get { return EntityData["aspects"]?.ToObject<Dictionary<string, int>>(); } set => EntityData["aspects"] = value != null ? JObject.FromObject(value) : null; }


        public Element(JObject entityData)
        {
            EntityData = entityData;
            if (entityData["id"] is not JToken id)
            {
                throw new Exception("Element without an ID encountered");
            }
            else
            {
                ID = id.ToString();
            }
        }
    }
}
