using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Journey.Communication.Responses;
public class ResponseShortTripJson
{
    [BsonId]
    public  ObjectId Id { get; set; }
    
    public string? Nome { get; set; }

    [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
    public DateTime StartDate { get; set; }

    [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
    public DateTime EndDate { get; set; }
}
