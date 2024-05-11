using MongoDB.Driver;
using ClanApplication.Models;
using Microsoft.Extensions.Options;
using ClanApplication.Data;

namespace ClanApplication.Services
{
    public class ClanServices
    {
        private readonly IMongoCollection<Clan> _clanCollection;
        private readonly IMongoCollection<User> _userCollection;
        private readonly IMongoCollection<Contribution> _contributionCollection;


        public ClanServices(IOptions<DatabaseSettings> settings)
        {
            var mongoClient = new MongoClient(settings.Value.Connection);
            var mongoDb = mongoClient.GetDatabase(settings.Value.DatabaseName);
            _clanCollection = mongoDb.GetCollection<Clan>(settings.Value.CollectionName);
            _userCollection = mongoDb.GetCollection<User>("Users");
            _contributionCollection = mongoDb.GetCollection<Contribution>("Contributions");

        }

        // Get all Clans
        public async Task<List<Clan>> GetAsync() => await _clanCollection.Find(_ => true).ToListAsync();


        // Get User by ID
        public async Task<User> GetAsync(string id) =>
            await _userCollection.Find(x => x.Id == id).FirstOrDefaultAsync();



        // Get all contributers to a clan
        public async Task<List<Contribution>> getClanContributors(string clan_id) =>
            await _contributionCollection.Find(x => x.clan_id == clan_id).ToListAsync();



        //Add User to Clan
        /*
        public async Task UpdateAsync(string  user_id, User updateUser)
        {
            await _userCollection.ReplaceOneAsync(x => x.Id == user_id, updateUser);
        }
        */
        //Remove User from Clan

        //Add, Sub, Set Points in a clan


        //Get all users of a clan

        //
    }
}
