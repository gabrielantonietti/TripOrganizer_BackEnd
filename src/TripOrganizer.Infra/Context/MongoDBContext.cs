using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripOrganizer.Infra.Context
{
    public class MongoDBContext
    {
        public string? ConnectionString { get; set; }
        public string? DatabaseName { get; set; }
        public string? TripsCollection {  get; set; }
        public string? ActivitiesCollection { get; set; }

    }
}
