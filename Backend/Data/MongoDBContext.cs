using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using ReviewAPI.Models;

namespace ReviewAPI.Data
{
    public class ReviewContext
    {
        private readonly IMongoDatabase _database;

        public ReviewContext(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("MongoDb"));
            _database = client.GetDatabase("ReviewDB");
        }

        public IMongoCollection<Review> Reviews => _database.GetCollection<Review>("Reviews");
    }
}
