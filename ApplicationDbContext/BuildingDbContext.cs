using System.Data.Common;
using BuldingManager.Configs;
using BuldingManager.Entities;
using Microsoft.EntityFrameworkCore;

namespace BuldingManager.ApplicationDbContext;

public class BuildingDbContext(DbContextOptions<BuildingDbContext> options)
    : Microsoft.EntityFrameworkCore.DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
           base.OnModelCreating(modelBuilder);
           modelBuilder.ApplyConfiguration(new PersonEntityConfiguration());
           modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
        
    }
    public DbSet<Persons> Persons { get; set; }
    public DbSet<Users> Users { get; set; }
}