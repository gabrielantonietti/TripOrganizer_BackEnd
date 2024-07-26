using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Journey.Communication.Responses;
public class ResponseTripJson
{
    [BsonId]
    public ObjectId Id { get; set; }
    public string? Name { get; set; }

    [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
    public DateTime StartDate { get; set; }

    [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
    public DateTime EndDate { get; set; }
    public IList<ResponseActivityJson> Activities { get; set; } = [];
}
