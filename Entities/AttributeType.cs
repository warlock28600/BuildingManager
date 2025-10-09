using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BuldingManager.Entities;

public class AttributeType
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AttributeTypeId { get; set; }
    
    public string AttributeTypeTitle { get; set; }
    
    public string Identifier { get; set; }

    [JsonIgnore]
    public ICollection<Attribute> Attributes { get; set; }
}