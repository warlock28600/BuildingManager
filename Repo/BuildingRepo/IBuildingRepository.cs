using BuldingManager.Dto;
using BuldingManager.Entities;

namespace BuldingManager.Repo.BuildingRepo;

public interface IBuildingRepository
{
    Task<IEnumerable<BuildingEntity>> GetBuildingsAsync();
    Task<BuildingEntity> GetBuildingAsync(int id);
    Task CreateAsync(BuildingCreateDto building);
    Task UpdateAsync(int id,BuildingCreateDto building);
    Task DeleteAsync(int id);
}