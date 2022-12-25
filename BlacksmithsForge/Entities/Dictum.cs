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


        public string? WorldSphereType { get { return EntityData["worldspheretype"]?.ToString(); } set => EntityData["worldspheretype"] = value; }
        public string? DefaultWorldSpherePath { get { return EntityData["DefaultWorldSpherePath"]?.ToString(); } set => EntityData["DefaultWorldSpherePath"] = value; }
        public List<string>? AlternativeDefaultWorldSpherePaths { get { return (List<string>?)(EntityData["alternativedefaultworldspherepaths"]?.Values<string>()); } set => EntityData["alternativedefaultworldspherepaths"] = value != null ? JArray.FromObject(value) : null; }
        public string? LogoScene { get { return EntityData["logoscene"]?.ToString(); } set => EntityData["logoscene"] = value; }
        public string? QuoteScene { get { return EntityData["quotescene"]?.ToString(); } set => EntityData["quotescene"] = value; }
        public string? MenuScene { get { return EntityData["menuscene"]?.ToString(); } set => EntityData["menuscene"] = value; }
        public string? PlayfieldScene { get { return EntityData["playfieldscene"]?.ToString(); } set => EntityData["playfieldscene"] = value; }
        public string? GameOverScene { get { return EntityData["gameoverscene"]?.ToString(); } set => EntityData["gameoverscene"] = value; }
        public string? NewGameScene { get { return EntityData["newgamescene"]?.ToString(); } set => EntityData["newgamescene"] = value; }
        public string? NoteElementId { get { return EntityData["noteelementid"]?.ToString(); } set => EntityData["noteelementid"] = value; }
        public float? DefaultTravelDuration { get { return EntityData["defaulttravelduration"]?.ToObject<float>() ?? 1; } set => EntityData["defaulttravelduration"] = value; }
        public int? DefaultGameSpeed { get { return EntityData["defaultgamespeed"]?.ToObject<int>() ?? 1; } set => EntityData["defaultgamespeed"] = value; }
        public float? DefaultQuickTravelDuration { get { return EntityData["defaultquicktravelduration"]?.ToObject<float>() ?? 1; } set => EntityData["defaultquicktravelduration"] = value; }



        public Dictum(JObject entityData)
        {
            EntityData = entityData;
        }

        public override string ToString()
        {
            return EntityData.ToString();
        }
    }
}
