using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BuldingManager.ApplicationDbContext;

public class BuildingDbContextFactory : IDesignTimeDbContextFactory<BuildingDbContext>
{
    public BuildingDbContext CreateDbContext(string[] args)
    {
        var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

        var optionsBuilder = new DbContextOptionsBuilder<BuildingDbContext>();

        // 👇 connection string برای PostgreSQL
        //optionsBuilder.UseNpgsql(config.GetConnectionString("DefaultConnection"));
        optionsBuilder.UseSqlServer(config.GetConnectionString("SqlServerConnection"));

        return new BuildingDbContext(optionsBuilder.Options);
    }
}
