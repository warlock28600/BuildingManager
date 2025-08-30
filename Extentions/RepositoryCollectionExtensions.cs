using BuldingManager.Repo.PersonRepo;

namespace BuldingManager.Extentions;

public static class RepositoryCollectionExtensions
{

    public static IServiceCollection AddApplicationRepositories(this IServiceCollection services)
    {
        
        
        services.AddScoped<IPersonRepository, PersonRepository>();
     
        return services;
    }
    
}