using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ReviewAPI.Models
{
    public class Review
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Content")]
        public string Content { get; set; }
    }
}
