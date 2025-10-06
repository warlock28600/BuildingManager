using BuldingManager.Dto.Unit;

namespace BuldingManager.Services.Unit;

public interface IUnitService
{
    public Task<UnitGetDto> GetUnitAsync(int id);
    public Task<IEnumerable<UnitGetDto>> GetUnitsAsync();
    public Task CreateUnit(UnitCreateDto unitCreateDto);
    public Task UpdateUnit(int id, UnitCreateDto unitCreateDto);
    public Task DeleteUnit(int id);
}