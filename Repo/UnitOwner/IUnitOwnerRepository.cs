using BuldingManager.Dto.UnitOwner;
using BuldingManager.Entities;

namespace BuldingManager.Repo.UnitOwner;

public interface IUnitOwnerRepository
{
    public Task<IEnumerable<Entities.UnitOwner>> getUnitOwners();
    public Task<Entities.UnitOwner> getUnitOwner(int id);
    public Task CreateUnitOwner(CreateUnitOwnerDto unitOwner);
    public Task UpdateUnitOwner(int id,CreateUnitOwnerDto unitOwner);
    public Task DeleteUnitOwner(int id);
}