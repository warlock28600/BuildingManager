// Extensions/ServiceCollectionExtensions.cs

using System.Reflection;
using AutoMapper;
using BuldingManager.Repo.PersonRepo;
using BuldingManager.Services.Athentication;
using BuldingManager.Services.Building;
using BuldingManager.Services.Person;
using BuldingManager.Services.Unit;

namespace BuldingManager.Extentions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
           
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IAthenticationService, AthenticationService>();
            services.AddScoped<IBuildingService, BuildingService>();
            services.AddScoped<IUnitService, UnitService>();

            // AutoMapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            // هر سرویس دیگه‌ای که خواستی...
            // services.AddScoped<IMyService, MyService>();

            return services;
        }
    }
}