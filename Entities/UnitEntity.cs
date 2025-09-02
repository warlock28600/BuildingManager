using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace BuldingManager.Entities;

public class UnitEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int UnitId { get; set; }
    public int BuildingId { get; set; }
    public string UnitNumber { get; set; }
    public string UnitTitle { get; set; }
    public string Floor { get; set; }

    
    public BuildingEntity Building { get; set; }
    public ICollection<UnitOwner> UnitOwners { get; set; }
    
}