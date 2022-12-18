using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithsForge.Mods
{
    public class Synopsis
    {
        public string? Name;
        public string? Version;
        public string? Author;
        public string? Description;
        public string? Description_Long;
        public string? Comments;
        public List<string>? Tags;

        [JsonConstructor]
        public Synopsis(string? name, string? version, string? author, string? description, string? description_long, string? comments, List<string> tags)
        {
            Name = name;
            Version = version;
            Author = author;
            Description = description;
            Description_Long = description_long;
            Comments = comments;
            Tags = tags;
        }

        public Synopsis()
        {

        }
    }
}
