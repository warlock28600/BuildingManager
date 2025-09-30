using BuldingManager.ApplicationDbContext;
using BuldingManager.Dto.UnitOwner;
using Microsoft.EntityFrameworkCore;

namespace BuldingManager.Repo.UnitOwner;

public class UnitOwnerRepository:IUnitOwnerRepository
{
    private readonly BuildingDbContext _context;
    private IUnitOwnerRepository _unitOwnerRepositoryImplementation;

    public UnitOwnerRepository(BuildingDbContext context)
    {
        _context=context;
    }
    
    
    public async Task<IEnumerable<Entities.UnitOwner>> GetUnitOwners(string extras)
    {
       var unitOwners = await _context.UnitOwners.ToListAsync();
       return unitOwners;
    }

    public async Task<Entities.UnitOwner> GetUnitOwner(int id )
    {
        var unitOwner = await _context.UnitOwners.FindAsync(id);
        return unitOwner;
    }

    public Task CreateUnitOwner(CreateUnitOwnerDto unitOwner)
    {
        throw new NotImplementedException();
    }

    public Task UpdateUnitOwner(int id, CreateUnitOwnerDto unitOwner)
    {
        throw new NotImplementedException();
    }

    public Task DeleteUnitOwner(int id)
    {
        throw new NotImplementedException();
    }
}