using Microsoft.Extensions.Options;
using MongoDB.Driver;
using TripOrganizer.Domain.Entities;
using TripOrganizer.Infra.Context;

namespace TripOrganizer.Infra.Repository
{
    public class TripsRepository
    {
        private readonly IMongoCollection<Trip> _TripsCollection;
        
        public TripsRepository(IOptions<MongoDBContext> mongoDBContext)
        {
            MongoClient client = new MongoClient(mongoDBContext.Value.ConnectionString);
            IMongoDatabase database = client.GetDatabase(mongoDBContext.Value.DatabaseName);
            _TripsCollection = database.GetCollection<Trip>(mongoDBContext.Value.TripsCollection);
        }

    }
}
