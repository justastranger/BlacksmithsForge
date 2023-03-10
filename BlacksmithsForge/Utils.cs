using BlacksmithsForge.Entities;
using BlacksmithsForge.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace BlacksmithsForge
{
    public static class Utils
    {
        private class PrepareJSONContractResolver : DefaultContractResolver
        {
            public PrepareJSONContractResolver() { }

            protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
            {
                List<JsonProperty> properties = base.CreateProperties(type, memberSerialization).ToList();
                properties.ForEach(property => property.PropertyName = property.PropertyName?.ToLower());
                return properties;
            }
        }

        public static readonly JsonSerializerSettings jsonSerializerSettings = new()
        {
            NullValueHandling = NullValueHandling.Ignore,
            Formatting = Formatting.Indented,
            ContractResolver = new PrepareJSONContractResolver()
        };

        public static string PluralToSingular(string name) {
            return name switch
            {
                "achievements" => "achievement",
                "cultures" => "culture",
                "decks" => "deck",
                "dicta" => "dictum",
                "elements" => "element",
                "endings" => "ending",
                "legacies" => "legacy",
                "levers" => "lever",
                "portals" => "portal",
                "recipes" => "recipe",
                "settings" => "setting",
                "verbs" => "verb",
                _ => "unknown",
            };
        }

        public static Type GetTypeFromRootName(string rootName)
        {
            return rootName switch
            {
                "achievements" => typeof(Achievement),
                "cultures" => typeof(Culture),
                "decks" => typeof(Deck),
                "elements" => typeof(Element),
                "endings" => typeof(Ending),
                "legacies" => typeof(Legacy),
                "levers" => typeof(Lever),
                "portals" => typeof(Portal),
                "recipes" => typeof(Recipe),
                "settings" => typeof(Setting),
                "verbs" => typeof(Verb),
                _ => throw new ArgumentException("Unknown Entity Root Type"),
            };
        }
        
        public static List<PropertyInfo> GetEntityProperties(Type entityType)
        {
            var unfiltered = entityType.GetProperties(BindingFlags.Instance | BindingFlags.Public);
            var implementedProperties = entityType.GetInterfaces().SelectMany(@interface => @interface.GetProperties()).ToList();
            var filter = unfiltered.Select((property) => property.Name).Except(implementedProperties.Select(property => property.Name)).ToList();
            List<PropertyInfo> filteredProperties = unfiltered.Where(property => filter.Contains(property.Name)).ToList();
            // Since ID is declared at the interface level, it gets filtered out
            // but we actually want to include it so we have to pop it back in
            filteredProperties.Add(entityType.GetProperty("ID", BindingFlags.Instance | BindingFlags.Public) ?? throw new NullReferenceException("Entity type missing ID property."));
            return filteredProperties;
        }

        public static List<string> GetEntityPropertyNames(Type entityType)
        {
            // Retrieve a *complete* list of property names for a Type, including IRootEntity and IEntity properties
            var unfilteredNames = entityType.GetProperties(BindingFlags.Instance | BindingFlags.Public).Select(property => property.Name.ToLower()).ToList();
            // Retrieve a list of just the IRootEntity and IEntity property names
            var interfaceProperties = entityType.GetInterfaces().SelectMany(@interface => @interface.GetProperties()).Select(property => property.Name.ToLower()).ToList();
            // And remove the latter from the former
            var filteredNames = unfilteredNames.Except(interfaceProperties);
            // Since ID is declared at the interface level, it gets filtered out
            // but we actually want to include it so we have to pop it back in
            return filteredNames.Prepend("id").ToList();
        }

        public static List<JProperty> GetUnknownProperties(JObject entityData, Type entityType)
        {
            // Basically the same process as above 
            List<string> knownProperties = GetEntityPropertyNames(entityType);
            
            var entityProperties = entityData.Properties().Select(property => property.Name.ToLower());

            var unknownProperties = entityProperties.Except(knownProperties);
            unknownProperties.Prepend("id");

            return entityData.Properties().Where(property => unknownProperties.Contains(property.Name.ToLower())).ToList();
        }

        public static string ToJson(object entity)
        {
            // purge null properties from JObjects passed to this function
            // there's no NullValueHandling property that covers JObjects so this needs to be done here
            if (entity is JObject jObject)
            {
                jObject.PurgeNullValues();
            } 
            return JsonConvert.SerializeObject(entity, jsonSerializerSettings);
        }

        public static void PurgeNullValues(this JToken jObject)
        {
            jObject.SelectTokens("$..*")
                    .OfType<JValue>()
                    .Where(value => value.Type == JTokenType.Null || value.Value == null)
                    .Select(nullValue => nullValue.Parent)
                    .ToList()
                    .ForEach(property => property?.Remove());
        }
    }
}
