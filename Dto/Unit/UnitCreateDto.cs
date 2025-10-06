namespace BuldingManager.Dto.Unit;

public class UnitCreateDto
{
    public int UnitId { get; set; }
    public int BuildingId { get; set; }
    public string UnitNumber { get; set; }
    public string UnitTitle { get; set; }
    public string Floor { get; set; }
    public int ExtraParkingCount { get; set; }
    public int unitArea { get; set; }
}