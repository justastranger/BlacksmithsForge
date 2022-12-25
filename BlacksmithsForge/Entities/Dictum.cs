using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithsForge.Entities
{
    public class Dictum : IRootEntity
    {

        public JObject EntityData { get; set; }
        public string ID
        {
            get
            {
                if (EntityData["id"] == null) throw new NullReferenceException("Deck ID must be specified.");
                else return EntityData["id"].ToString();
            }
            set => EntityData["id"] = value;
        }
        public Guid Guid { get; set; } = Guid.NewGuid();
        public string? Filename { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? WorldSphereType { get { return EntityData["worldspheretype"]?.ToString(); } set => EntityData["worldspheretype"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultWorldSpherePath { get { return EntityData["defaultworldspherepath"]?.ToString(); } set => EntityData["defaultworldspherepath"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<string>? AlternativeDefaultWorldSpherePaths { get { return (List<string>?)(EntityData["alternativedefaultworldspherepaths"]?.Values<string>()); } set => EntityData["alternativedefaultworldspherepaths"] = value != null ? JArray.FromObject(value) : null; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? LogoScene { get { return EntityData["logoscene"]?.ToString(); } set => EntityData["logoscene"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? QuoteScene { get { return EntityData["quotescene"]?.ToString(); } set => EntityData["quotescene"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? MenuScene { get { return EntityData["menuscene"]?.ToString(); } set => EntityData["menuscene"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? PlayfieldScene { get { return EntityData["playfieldscene"]?.ToString(); } set => EntityData["playfieldscene"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? GameOverScene { get { return EntityData["gameoverscene"]?.ToString(); } set => EntityData["gameoverscene"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? NewGameScene { get { return EntityData["newgamescene"]?.ToString(); } set => EntityData["newgamescene"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? NoteElementId { get { return EntityData["noteelementid"]?.ToString(); } set => EntityData["noteelementid"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public float? DefaultTravelDuration { get { return EntityData["defaulttravelduration"]?.ToObject<float?>() ?? 1; } set => EntityData["defaulttravelduration"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultGameSpeed { get { return EntityData["defaultgamespeed"]?.ToObject<int?>() ?? 1; } set => EntityData["defaultgamespeed"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public float? DefaultQuickTravelDuration { get { return EntityData["defaultquicktravelduration"]?.ToObject<float?>() ?? 1; } set => EntityData["defaultquicktravelduration"] = value; }



        public Dictum(JObject entityData)
        {
            EntityData = entityData;
        }

        public override string ToString()
        {
            return Utils.ToJson(EntityData);
        }
    }
}
