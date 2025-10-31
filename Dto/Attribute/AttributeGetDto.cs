using BuldingManager.Entities;

namespace BuldingManager.Dto.Attribute
{
    public class AttributeGetDto:BaseEntity
    {
        public int AttributeId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
