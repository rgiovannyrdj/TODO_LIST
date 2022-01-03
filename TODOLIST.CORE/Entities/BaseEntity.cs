using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TODOLIST.CORE.Entities
{
    public class BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ID { get; set; }
    }
}
