using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripOrganizer.Domain.Entities
{
    public class Trip : BaseEntity
    {

        [BsonElement("name")]
        public String? Nome { get; set; }

        [BsonElement("startDate")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime StartDate { get; set; }

        [BsonElement("endDate")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime EndDate { get; set; }

        public IList<Activity> Activities { get; set; } = [];
    }
}
