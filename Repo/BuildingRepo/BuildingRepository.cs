using AutoMapper;
using BuldingManager.ApplicationDbContext;
using BuldingManager.Dto;
using BuldingManager.Entities;
using Microsoft.EntityFrameworkCore;

namespace BuldingManager.Repo.BuildingRepo;

public class BuildingRepository:IBuildingRepository
{
    private readonly IMapper _mapper;
    private readonly BuildingDbContext _context;
    public BuildingRepository(BuildingDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    
    public async Task<IEnumerable<BuildingEntity>> GetBuildingsAsync()
    {
        var buildings = await _context.BuildingEntities.Include(b=>b.Units).ToListAsync();
        return buildings;
    }

    public async Task<BuildingEntity> GetBuildingAsync(int id)
    {
        var building = await _context.BuildingEntities.Include(b => b.Units).FirstOrDefaultAsync(b => b.Id == id);

        if (building == null)
        {
            throw new KeyNotFoundException($"Building with id {id} not found");
        }
        return building;
    }

    public async Task CreateAsync(BuildingCreateDto building)
    {
        var buildingEntity = _mapper.Map<BuildingEntity>(building);
        _context.BuildingEntities.Add(buildingEntity);
        await _context.SaveChangesAsync(); 
    }

    public async Task UpdateAsync(int id, BuildingCreateDto building)
    {
        var buildingEntity = await GetBuildingAsync(id);
        if (buildingEntity == null)
        {
            throw new KeyNotFoundException($"Building with id {id} not found");
        }
        _mapper.Map(building, buildingEntity);
        _context.Entry(buildingEntity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var buildingEntity = await GetBuildingAsync(id);
        if (buildingEntity == null)
        {
            throw new KeyNotFoundException($"Building with id {id} not found");
        }
        _context.BuildingEntities.Remove(_mapper.Map<BuildingEntity>(buildingEntity));
        await _context.SaveChangesAsync();
    }
}