using BuldingManager.Repo.AthenticationRepo;
using BuldingManager.Repo.BuildingRepo;
using BuldingManager.Repo.PersonRepo;
using BuldingManager.Repo.UnitOwner;
using BuldingManager.Repo.UnitRepo;

namespace BuldingManager.Extentions;

public static class RepositoryCollectionExtensions
{

    public static IServiceCollection AddApplicationRepositories(this IServiceCollection services)
    {
        
        
        services.AddScoped<IPersonRepository, PersonRepository>();
        services.AddScoped<IAthenticationRepository, AthenticationRepository>();
        services.AddScoped<IBuildingRepository, BuildingRepository>();
        services.AddScoped<IUnitRepository, UnitRepository>();
        services.AddScoped<IUnitOwnerRepository, UnitOwnerRepository>();
     
        return services;
    }
    
}