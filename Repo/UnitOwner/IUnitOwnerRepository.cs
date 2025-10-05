using BuldingManager.Dto.UnitOwner;
using BuldingManager.Entities;

namespace BuldingManager.Repo.UnitOwner;

public interface IUnitOwnerRepository
{
    public Task<IEnumerable<Entities.UnitOwner>> GetUnitOwners(string extra);
    public Task<Entities.UnitOwner> GetUnitOwner(int id);
    public Task CreateUnitOwner(Entities.UnitOwner unitOwner);
    public Task UpdateUnitOwner(int id,Entities.UnitOwner unitOwner);
    public Task DeleteUnitOwner(int id);
}