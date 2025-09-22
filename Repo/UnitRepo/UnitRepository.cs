using AutoMapper;
using BuldingManager.ApplicationDbContext;
using BuldingManager.Dto.Unit;
using BuldingManager.Entities;
using Microsoft.EntityFrameworkCore;

namespace BuldingManager.Repo.UnitRepo;

public class UnitRepository:IUnitRepository
{
    private readonly BuildingDbContext _context;
    private readonly IMapper _mapper;

    public UnitRepository(BuildingDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper=mapper;
    }
    
    public async Task<IEnumerable<UnitEntity>> GetAllUnits()
    {
        var units = await _context.UnitEntities.Include(u => u.Building).ToArrayAsync();
        if (units.Length == 0)
        {
            throw new Exception("No units found");
        }
        return units;
    }

    public async Task<UnitEntity> GetUnitById(int id)
    {
        var unit = await _context.UnitEntities.SingleOrDefaultAsync(u => u.UnitId==id);
        if (unit == null)
        {
            throw new Exception("No units found");
        }
        return unit;
        
    }

    public Task CreateUnit(UnitEntity unit)
    {
        _context.UnitEntities.Add(unit);
        _context.SaveChangesAsync();
        return Task.CompletedTask;
    }

    public async Task UpdateUnit(int id, UnitCreateDto unit)
    {
        var unitEntity = await GetUnitById(id);
        if (unitEntity == null)
        {
            throw new Exception("No units found");
        }
        _mapper.Map(unit, unitEntity);
        _context.UnitEntities.Update(unitEntity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteUnit(int id)
    {
        var unitEntity = await GetUnitById(id);
        if (unitEntity == null)
        {
            throw new Exception("No units found");
        }
        _context.UnitEntities.Remove(unitEntity);
        await _context.SaveChangesAsync();
    }
}