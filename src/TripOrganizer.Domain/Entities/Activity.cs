using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripOrganizer.Domain.Enum;

namespace TripOrganizer.Domain.Entities
{
    public class Activity : BaseEntity
    {
        [BsonElement("name")]
        public String? Nome {  get; set; }

        [BsonElement("date")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime StartDate { get; set; }

        [BsonElement("status")]
        public ActivityStatus Status { get; set; }

        [BsonId]
        [BsonElement("tripId")]
        public ObjectId TripId { get; set; }
    }
}
