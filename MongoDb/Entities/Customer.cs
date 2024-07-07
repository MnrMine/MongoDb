using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MongoDb.Entities
{
    public class Customer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? CustomerId { get; set; }
        public string? CustomerNameSurname { get; set; }
        public string? CustomerCity { get; set; }
        public string? CustomerPhone { get; set; }
        public string? CustomerMail { get; set; }
    }
}
