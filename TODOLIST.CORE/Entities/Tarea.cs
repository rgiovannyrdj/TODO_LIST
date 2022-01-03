using MongoDB.Bson.Serialization.Attributes;

namespace TODOLIST.CORE.Entities
{
    public class Tarea: BaseEntity
    {
        [BsonElement("description")]
        public string Description { get; set; } = string.Empty;
        [BsonElement("createDate")]
        public DateTime CreateDate { get; set; }
        [BsonElement("updateDate")]
        public DateTime? UpdateDate { get; set; }
    }
}
