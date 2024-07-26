using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using TripOrganizer.Domain.Enum;


public class ResponseActivityJson
{
    [BsonId]
    public ObjectId Id { get; set; }
    public string? Name { get; set; }

    [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
    public DateTime Date { get; set; }
    public ActivityStatus Status { get; set; }
}
