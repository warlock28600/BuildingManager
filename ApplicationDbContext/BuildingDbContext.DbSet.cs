using BuldingManager.Entities;
using Microsoft.EntityFrameworkCore;

namespace BuldingManager.ApplicationDbContext;

public partial class BuildingDbContext
{
    public DbSet<Persons> Persons { get; set; }
    public DbSet<Users> Users { get; set; }
    public DbSet<BuildingEntity> BuildingEntities { get; set; }
    public DbSet<UnitEntity> UnitEntities { get; set; }
    public DbSet<UnitOwner> UnitOwners { get; set; }
    
    public DbSet<AttributeType> AttributeTypes { get; set; }
}