﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithsForge.Entities
{
    internal class Deck : IEntity
    {
        public JObject EntityData { get; set; }
        public string ID { get; set; }
        public Guid Guid { get; set; } = new();

        public string? Label { get { return EntityData["label"]?.ToString(); } set => EntityData["label"] = value; }
        public string? Description { get { return EntityData["description"]?.ToString(); } set => EntityData["description"] = value; }
        public string? Comments { get { return EntityData["comments"]?.ToString(); } set => EntityData["comments"] = value; }
        public string? Cover { get { return EntityData["cover"]?.ToString() ?? "books"; } set => EntityData["cover"] = value; }
        public string? DefaultCard { get { return EntityData["defaultcard"]?.ToString(); } set => EntityData["defaultcard"] = value; }
        public bool? IsHidden { get { return EntityData["ishidden"]?.ToObject<bool>(); } set => EntityData["ishidden"] = value; }
        public bool? ResetOnExhaustion { get { return EntityData["resetonexhaustion"]?.ToObject<bool>(); } set => EntityData["resetonexhaustion"] = value; }
        public int? Draws { get { return EntityData["draws"]?.ToObject<int>() ?? 1; } set => EntityData["draws"] = value; }
        public List<string>? Spec { get { return (List<string>?)(EntityData["spec"]?.Values<string>()); } set => EntityData["spec"] = value != null ? JArray.FromObject(value) : null; }


        public Deck(JObject entityData)
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