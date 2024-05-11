using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace ClanApplication.Models
{
    public class Clan
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;


        [BsonElement("name")]
        public string name { get; set; } = "name";


        [BsonElement("members")]
        public int members { get; set; }


    }
}
