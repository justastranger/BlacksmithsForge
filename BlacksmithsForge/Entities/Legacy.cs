using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithsForge.Entities
{
    public class Legacy : IRootEntity
    {
        public JObject EntityData { get; set; }
        public string ID
        {
            get
            {
                if (EntityData["id"] == null) throw new NullReferenceException("Legacy ID must be specified.");
                else return EntityData["id"].ToString();
            }
            set => EntityData["id"] = value;
        }
        public Guid Guid { get; set; } = Guid.NewGuid();
        public string? Filename { get; set; }

        public string? Label { get { return EntityData["label"]?.ToString(); } set => EntityData["label"] = value; }
        public string? Description { get { return EntityData["description"]?.ToString(); } set => EntityData["description"] = value; }
        public string? StartDescription { get { return EntityData["startdescription"]?.ToString(); } set => EntityData["startdescription"] = value; }
        public string? Image { get { return EntityData["image"]?.ToString(); } set => EntityData["image"] = value; }
        public string? Family { get { return EntityData["family"]?.ToString(); } set => EntityData["family"] = value; }
        public string? TableCoverImage { get { return EntityData["tablecoverimage"]?.ToString(); } set => EntityData["tablecoverimage"] = value; }
        public string? TableSurfaceImage { get { return EntityData["tablesurfaceimage"]?.ToString(); } set => EntityData["tablesurfaceimage"] = value; }
        public string? TableEdgeImage { get { return EntityData["tableedgeimage"]?.ToString(); } set => EntityData["tableedgeimage"] = value; }
        public string? FromEnding { get { return EntityData["fromending"]?.ToString(); } set => EntityData["fromending"] = value; }
        public bool? AvailableWithoutEndingMatch { get { return EntityData["availablewithoutendingmatch"]?.ToObject<bool>(); } set => EntityData["availablewithoutendingmatch"] = value; }
        public bool? NewStart { get { return EntityData["newstart"]?.ToObject<bool>(); } set => EntityData["newstart"] = value; }
        public Dictionary<string, int>? Effects { get { return EntityData["effects"]?.ToObject<Dictionary<string, int>>(); } set => EntityData["effects"] = value != null ? JObject.FromObject(value) : null; }
        public List<RecipeLink>? Startup { get { return (List<RecipeLink>?)(EntityData["startup"]?.Values<RecipeLink>()); } set => EntityData["startup"] = value != null ? JArray.FromObject(value) : null; }
        public List<string>? ExcludesOnEnding { get { return (List<string>?)(EntityData["excludesonending"]?.Values<string>()); } set => EntityData["excludesonending"] = value != null ? JArray.FromObject(value) : null; }
        public List<string>? StatusBarElements { get { return (List<string>?)(EntityData["statusbarelements"]?.Values<string>()); } set => EntityData["statusbarelements"] = value != null ? JArray.FromObject(value) : null; }
        public string? StartingVerbId { get { return EntityData["startingverbid"]?.ToString(); } set => EntityData["startingverbid"] = value; }



        public Legacy(JObject entityData)
        {
            EntityData = entityData;
        }

        public override string ToString()
        {
            return EntityData.ToString();
        }
    }
}
