
namespace BuldingManager.Entities
{
    public class Attribute:BaseEntity
    {
        public int AttributeId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int AttributeTypeId { get; set; }
        public AttributeType AttributeType{ get; set; }
    }
}
