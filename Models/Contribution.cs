using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace ClanApplication.Models
{
    public class Contribution
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        [BsonElement("clan_id"), BsonRepresentation(BsonType.ObjectId)]
        public string clan_id { get; set; } = string.Empty;

        [BsonElement("user_id"), BsonRepresentation(BsonType.ObjectId)]
        public string user_id { get; set; } = string.Empty;


        [BsonElement("amount")]
        public int amount { get; set; }
    }
}
