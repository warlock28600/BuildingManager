using BuldingManager.Entities;

namespace BuldingManager.Dto;

public class BuildingGetDto:BaseEntity
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string BuildingAddress { get; set; }
    public string BuildingNumber { get; set; }
    public int CompoundId { get; set; }
    public ICollection<UnitEntity> Units { get; set; }
}