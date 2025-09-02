using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuldingManager.Entities;

public class BuildingEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string Title { get; set; }

    public string BuildingAddress { get; set; }
    public string BuildingNumber { get; set; }

    public ICollection<UnitEntity> Units { get; set; }
    
}