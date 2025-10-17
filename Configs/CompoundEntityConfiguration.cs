using BuldingManager.ApplicationDbContext;
using BuldingManager.Entities;
using Microsoft.EntityFrameworkCore;

namespace BuldingManager.Configs
{
    public class CompoundEntityConfiguration : IEntityTypeConfiguration<Compounds>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Compounds> builder)
        {
            builder.Property(c => c.Title).HasMaxLength(200).IsRequired();
            builder.HasMany(c => c.Buildings)
                .WithOne(b => b.Compound)
                .HasForeignKey(b => b.CompoundId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
