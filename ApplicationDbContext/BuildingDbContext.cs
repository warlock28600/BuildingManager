using System.Data.Common;
using BuldingManager.Configs;
using BuldingManager.Entities;
using Microsoft.EntityFrameworkCore;

namespace BuldingManager.ApplicationDbContext;

public partial class BuildingDbContext(DbContextOptions<BuildingDbContext> options)
    : Microsoft.EntityFrameworkCore.DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
           base.OnModelCreating(modelBuilder);
           modelBuilder.ApplyAllEntityConfigurations();

    }
}