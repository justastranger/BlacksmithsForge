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
        Guid Guid { get; set; }
        JObject EntityData { get; set; }
    }

    public interface IEntityWithId : IEntity
    {
        string ID { get; set; }
        // string Lever { get; set; }
    }

    public interface IRootEntity : IEntityWithId
    {
        string? Filename { get; set; }
    }

    public interface ILink
    {
        JObject EntityData { get; set; }
        string ID { get; set; }
    }
}
