﻿using BlacksmithsForge.Entities;
using System;
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
    internal class Utils
    {
        public static string PluralToSingular(string name) {
            return name switch
            {
                "achievements" => "achievement",
                "cultures" => "culture",
                "decks" => "deck",
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
