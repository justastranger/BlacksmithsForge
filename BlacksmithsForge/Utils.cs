using BlacksmithsForge.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithsForge
{
    internal class Utils
    {
        public static string PluralToSingular(string name) {
            switch (name)
            {
                case "achievements": return "achievement";
                case "cultures": return "culture";
                case "decks": return "deck";
                case "elements": return "element";
                case "endings": return "ending";
                case "legacies": return "legacy";
                case "levers": return "lever";
                case "portals": return "portal";
                case "recipes": return "recipe";
                case "settings": return "setting";
                case "verbs": return "verb";
                default: return "unknown";
            }
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
            var unfilteredNames = entityType.GetProperties(BindingFlags.Instance | BindingFlags.Public).Select(property => property.Name).ToList();
            // Retrieve a list of just the IRootEntity and IEntity property names
            var interfaceProperties = entityType.GetInterfaces().SelectMany(@interface => @interface.GetProperties()).Select(property => property.Name).ToList();
            // And remove the latter from the former
            List<string> filteredNames = unfilteredNames.Except(interfaceProperties).ToList();
            // Since ID is declared at the interface level, it gets filtered out
            // but we actually want to include it so we have to pop it back in
            return filteredNames.Prepend("ID").ToList();
        }
    }
}
