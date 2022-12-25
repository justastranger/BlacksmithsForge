using BlacksmithsForge.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace BlacksmithsForge
{
    public class Utils
    {
        private class LowerCaseContractResolver : DefaultContractResolver
        {
            public LowerCaseContractResolver() { }

            protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
            {
                List<JsonProperty> properties = base.CreateProperties(type, memberSerialization).ToList();
                properties.ForEach(property => property.PropertyName = property.PropertyName?.ToLower());
                return properties;
            }
        }

        private static readonly JsonSerializer jsonSerializer = new()
        {
            NullValueHandling = NullValueHandling.Ignore,
            Formatting = Formatting.Indented,
            ContractResolver = new LowerCaseContractResolver()
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

        public static string ToJson(IEntity entity)
        {
            StringBuilder stringBuilder = new();
            using StringWriter stringWriter = new(stringBuilder);
            using JsonTextWriter jsonTextWriter = new(stringWriter);
            jsonSerializer.Serialize(jsonTextWriter, entity);
            jsonTextWriter.Flush();
            return stringBuilder.ToString();
        }
    }
}
