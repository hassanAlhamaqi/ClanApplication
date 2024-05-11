using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace ClanApplication.Models
{


    [BsonIgnoreExtraElements]
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        [BsonElement("username")]
        public string username { get; set; } = "Username";


        [BsonElement("clan_id"), BsonRepresentation(BsonType.ObjectId)]
        public string clan_id { get; set; } = string.Empty;

    }
}
