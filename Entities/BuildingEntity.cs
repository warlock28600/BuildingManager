using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BuldingManager.Entities;

public class BuildingEntity:BaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string Title { get; set; }

    public string BuildingAddress { get; set; }
    public string BuildingNumber { get; set; }
    [JsonIgnore]
    public ICollection<UnitEntity> Units { get; set; }
    
}