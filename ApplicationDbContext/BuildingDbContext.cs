using BuldingManager.Configs;
using BuldingManager.Domain;
using BuldingManager.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data.Common;

namespace BuldingManager.ApplicationDbContext;

public partial class BuildingDbContext(DbContextOptions<BuildingDbContext> options)
    : Microsoft.EntityFrameworkCore.DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
           base.OnModelCreating(modelBuilder);
           modelBuilder.ApplyAllEntityConfigurations();

        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            if (typeof(BaseEntity).IsAssignableFrom(entityType.ClrType))
            {
                var method = typeof(BuildingDbContext)
                    .GetMethod(nameof(SetSoftDeleteFilter), System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static)
                    ?.MakeGenericMethod(entityType.ClrType);

                method?.Invoke(null, new object[] { modelBuilder });
            }
        }

    }

    public override int SaveChanges()
    {
        AuditHelper.ApplyAuditInfo(ChangeTracker);
        return base.SaveChanges();
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        AuditHelper.ApplyAuditInfo(ChangeTracker);
        return await base.SaveChangesAsync(cancellationToken);
    }

    private static void SetSoftDeleteFilter<T>(ModelBuilder builder) where T : BaseEntity
    {
        builder.Entity<T>().HasQueryFilter(x => !x.IsDeleted);
    }
}