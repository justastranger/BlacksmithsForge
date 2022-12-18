using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithsForge.Entities
{
    public interface IEntity
    {
        JObject EntityData { get; set; }
        string ID { get; set; }
        Guid Guid { get; set; }
        // string Lever { get; set; }
    }

    public interface IRootEntity : IEntity
    {
        string? Filename { get; set; }
    }
}
