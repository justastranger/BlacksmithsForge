using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithsForge.Entities
{
    public class Recipe : IRootEntity, ILink
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
        public string? Filename { get; set; }

        // references Verb ID
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? ActionId { get { return EntityData["actionid"]?.ToString(); } set => EntityData["actionid"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string>? Requirements { get { return EntityData["requirements"]?.ToObject<Dictionary<string, string>?>(); } set => EntityData["requirements"] = value != null ? JObject.FromObject(value) : null; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string>? NearbyReqs { get { return EntityData["nearbyreqs"]?.ToObject<Dictionary<string, string>?>(); } set => EntityData["nearbyreqs"] = value != null ? JObject.FromObject(value) : null; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string>? TableReqs { get { return EntityData["tablereqs"]?.ToObject<Dictionary<string, string>?>(); } set => EntityData["tablereqs"] = value != null ? JObject.FromObject(value) : null; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string>? ExtantReqs { get { return EntityData["extantreqs"]?.ToObject<Dictionary<string, string>?>(); } set => EntityData["extantreqs"] = value != null ? JObject.FromObject(value) : null; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string>? Seeking { get { return EntityData["seeking"]?.ToObject<Dictionary<string, string>?>(); } set => EntityData["seeking"] = value != null ? JObject.FromObject(value) : null; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string>? Effects { get { return EntityData["effects"]?.ToObject<Dictionary<string, string>?>(); } set => EntityData["effects"] = value != null ? JObject.FromObject(value) : null; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string>? DeckEffects { get { return EntityData["deckeffects"]?.ToObject<Dictionary<string, string>?>(); } set => EntityData["deckeffects"] = value != null ? JObject.FromObject(value) : null; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, int>? Aspects { get { return EntityData["aspects"]?.ToObject<Dictionary<string, int>?>(); } set => EntityData["aspects"] = value != null ? JObject.FromObject(value) : null; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Mutation>? Mutations { get { return (List<Mutation>?)(EntityData["mutations"]?.Values<Mutation>()); } set => EntityData["mutations"] = value != null ? JArray.FromObject(value) : null; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, int>? Purge { get { return EntityData["purge"]?.ToObject<Dictionary<string, int>?>(); } set => EntityData["purge"] = value != null ? JObject.FromObject(value) : null; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, int>? HaltVerb { get { return EntityData["haltverb"]?.ToObject<Dictionary<string, int>?>(); } set => EntityData["haltverb"] = value != null ? JObject.FromObject(value) : null; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, int>? DeleteVerb { get { return EntityData["deleteverb"]?.ToObject<Dictionary<string, int>?>(); } set => EntityData["deleteverb"] = value != null ? JObject.FromObject(value) : null; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<string>? Achievements { get { return (List<string>?)(EntityData["achievements"]?.Values<string>()); } set => EntityData["achievements"] = value != null ? JArray.FromObject(value) : null; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? SignalImportantLoop { get { return EntityData["signalimportantloop"]?.ToObject<bool?>(); } set => EntityData["signalimportantloop"] = value; }
        // options: None, Grand, Melancholy, Pale, Vile
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? SignalEndingFlavour { get { return EntityData["signalendingflavour"]?.ToString(); } set => EntityData["signalendingflavour"] = value; }
        public bool? Craftable { get { return EntityData["craftable"]?.ToObject<bool?>(); } set => EntityData["craftable"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? HintOnly { get { return EntityData["hintonly"]?.ToObject<bool?>(); } set => EntityData["hintonly"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? Warmup { get { return EntityData["warmup"]?.ToObject<int?>(); } set => EntityData["warmup"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Label { get { return EntityData["label"]?.ToString(); } set => EntityData["label"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Description { get { return EntityData["description"]?.ToString(); } set => EntityData["description"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? StartDescription { get { return EntityData["startdescription"]?.ToString(); } set => EntityData["startdescription"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Comments { get { return EntityData["comments"]?.ToString(); } set => EntityData["comments"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<RecipeLink>? Alt { get { return (List<RecipeLink>?)(EntityData["alt"]?.Values<RecipeLink>()); } set => EntityData["alt"] = value != null ? JArray.FromObject(value) : null; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<RecipeLink>? LateAlt { get { return (List<RecipeLink>?)(EntityData["latealt"]?.Values<RecipeLink>()); } set => EntityData["latealt"] = value != null ? JArray.FromObject(value) : null; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<RecipeLink>? Linked { get { return (List<RecipeLink>?)(EntityData["linked"]?.Values<RecipeLink>()); } set => EntityData["linked"] = value != null ? JArray.FromObject(value) : null; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<RecipeLink>? Inductions { get { return (List<RecipeLink>?)(EntityData["inductions"]?.Values<RecipeLink>()); } set => EntityData["inductions"] = value != null ? JArray.FromObject(value) : null; }
        // references Ending ID
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Ending { get { return EntityData["ending"]?.ToString(); } set => EntityData["ending"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxExecutions { get { return EntityData["maxexecutions"]?.ToObject<int?>(); } set => EntityData["maxexecutions"] = value; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? BurnImage { get { return EntityData["burnimage"]?.ToString(); } set => EntityData["burnimage"] = value; }
        // references Portal ID
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? PortalEffect { get { return EntityData["portaleffect"]?.ToString(); } set => EntityData["portaleffect"] = value; }
        // only one slot can be in the list
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Sphere>? Slots { get { return (List<Sphere>?)(EntityData["slots"]?.Values<Sphere>()); } set => EntityData["slots"] = value != null ? JArray.FromObject(value) : null; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Deck? InternalDeck { get { return EntityData["internaldeck"]?.ToObject<Deck?>(); } set => EntityData["internaldeck"] = value != null ? JObject.FromObject(value) : null; }


        public Recipe(JObject entityData)
        {
            EntityData = entityData;
        }

        public Recipe() : this(new())
        {

        }

        public override string ToString()
        {
            return Utils.ToJson(EntityData);
        }
    }
}
