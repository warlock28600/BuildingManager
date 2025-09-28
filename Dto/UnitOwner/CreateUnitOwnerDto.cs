namespace BuldingManager.Dto.UnitOwner;

public class CreateUnitOwnerDto
{
    public int UnitId { get; set; }
    public int PersonId { get; set; }
    public double? OwnerShipPercent { get; set; }
    public int HouseholdCount { get; set; }
}