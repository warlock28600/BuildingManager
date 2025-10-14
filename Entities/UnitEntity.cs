using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Serialization;

namespace BuldingManager.Entities;

public class UnitEntity:BaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int UnitId { get; set; }
    
    public int BuildingId { get; set; }
    public string UnitNumber { get; set; }
    public string UnitTitle { get; set; }
    public string Floor { get; set; }
    
    public BuildingEntity Building { get; set; }
    [JsonIgnore]
    public ICollection<UnitOwner> UnitOwners { get; set; }
    [JsonIgnore]
    public ICollection<ResidentEntity> Residents { get; set; }

}