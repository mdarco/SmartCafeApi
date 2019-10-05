using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SmartCafeApi.Mongo.Models
{
    [BsonIgnoreExtraElements]
    public class Table
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("tag")]
        public string Tag { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        [BsonElement("isInUse")]
        public bool IsInUse { get; set; }

        [BsonElement("createdAt")]
        public DateTime CreatedAt { get; set; }

        [BsonElement("updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }
}
