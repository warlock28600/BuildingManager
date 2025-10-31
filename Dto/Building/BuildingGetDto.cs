using BuldingManager.Entities;

namespace BuldingManager.Dto;

public class BuildingGetDto:BaseEntity
{
    public string Title { get; set; }
    public string BuildingAddress { get; set; }
    public string BuildingNumber { get; set; }
    public ICollection<UnitEntity> Units { get; set; }
}