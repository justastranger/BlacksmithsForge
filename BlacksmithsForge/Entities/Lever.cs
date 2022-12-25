﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithsForge.Entities
{
    public class Lever : IRootEntity
    {
        public JObject EntityData { get; set; }
        public string ID
        {
            get
            {
                if (EntityData["id"] == null) throw new NullReferenceException("Lever ID must be specified.");
                else return EntityData["id"].ToString();
            }
            set => EntityData["id"] = value;
        }
        public Guid Guid { get; set; } = Guid.NewGuid();
        public string? Filename { get; set; }

        public string? RecordKey { get { return EntityData["recordkey"]?.ToString(); } set => EntityData["recordkey"] = value; }
        public Dictionary<string, int>? Weights { get { return EntityData["weights"]?.ToObject<Dictionary<string, int>>(); } set => EntityData["weights"] = value != null ? JObject.FromObject(value) : null; }
        public int? RequiredScore { get { return EntityData["requiredscore"]?.ToObject<int>(); } set => EntityData["requiredscore"] = value; }
        // keys and values must both reference Elements
        public Dictionary<string, string>? Redirects { get { return EntityData["redirects"]?.ToObject<Dictionary<string, string>>(); } set => EntityData["redirects"] = value != null ? JObject.FromObject(value) : null; }
        public bool? OnGameEnd { get { return EntityData["ongameend"]?.ToObject<bool>(); } set => EntityData["ongameend"] = value; }
        public string? Comments { get { return EntityData["comments"]?.ToString(); } set => EntityData["comments"] = value; }



        public Lever(JObject entityData)
        {
            EntityData = entityData;
        }

        public override string ToString()
        {
            return EntityData.ToString();
        }
    }
}
