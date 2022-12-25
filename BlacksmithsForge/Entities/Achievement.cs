using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithsForge.Entities
{
    public class Achievement : IRootEntity
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

        public string? Label { get { return EntityData["label"]?.ToString(); } set => EntityData["label"] = value; }
        public string? DescriptionLocked { get { return EntityData["descriptionlocked"]?.ToString(); } set => EntityData["descriptionlocked"] = value; }
        public string? DescriptionUnlocked { get { return EntityData["descriptionunlocked"]?.ToString(); } set => EntityData["descriptionunlocked"] = value; }
        public bool? SingleDescription { get { return EntityData["singledescription"]?.ToObject<bool?>(); } set => EntityData["singledescription"] = value; }
        public string? IconUnlocked { get { return EntityData["iconunlocked"]?.ToString(); } set => EntityData["iconunlocked"] = value; }
        public string? IconLocked { get { return EntityData["iconlocked"]?.ToString(); } set => EntityData["iconlocked"] = value; }
        public string? UnlockMessage { get { return EntityData["unlockmessage"]?.ToString(); } set => EntityData["unlockmessage"] = value; }
        public bool? IsHidden { get { return EntityData["ishidden"]?.ToObject<bool?>(); } set => EntityData["ishidden"] = value; }
        public bool? IsCategory { get { return EntityData["iscategory"]?.ToObject<bool?>(); } set => EntityData["iscategory"] = value; }
        public string? Category { get { return EntityData["category"]?.ToString(); } set => EntityData["category"] = value; }
        // should basically always be false for custom achievements
        public bool? ValidateOnStorefront { get { return EntityData["validateonstorefront"]?.ToObject<bool?>(); } set => EntityData["validateonstorefront"] = value; }



        public Achievement(JObject entityData)
        {
            EntityData = entityData;
        }

        public override string ToString()
        {
            return Utils.ToJson(this);
        }
    }
}
