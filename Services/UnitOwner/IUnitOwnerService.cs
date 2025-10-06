using BuldingManager.Dto.UnitOwner;
using BuldingManager.Profiles;

namespace BuldingManager.Services.UnitOwner;

public interface IUnitOwnerService
{
    public Task<IEnumerable<GetUnitOwnerDto>>  GetUnitOwners(string extra);
    public Task<GetUnitOwnerDto> GetUnitOwner(int id);
    public Task CreateUnitOwner(CreateUnitOwnerDto createUnitOwnerDto);
    public Task UpdateUnitOwner(int id, CreateUnitOwnerDto createUnitOwnerDto);
    public Task DeleteUnitOwner(int id);
    
}