using BuldingManager.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BuldingManager.Configs;

public class PersonEntityConfiguration:IEntityTypeConfiguration<Persons>
{
    public void Configure(EntityTypeBuilder<Persons> builder)
    {
        builder.Property(e => e.Email).HasMaxLength(256).IsRequired().HasColumnType("varchar(256)");
        builder.Property(e => e.Phone).HasMaxLength(8).IsRequired().HasColumnType("varchar(50)");
        builder.Property(e => e.Address).HasMaxLength(256).IsRequired().HasColumnType("varchar(256)");
        builder.Property(e=>e.FirstName).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
        builder.Property(e => e.LastName).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
        builder.Property(e => e.Mobile).HasMaxLength(10).IsRequired().HasColumnType("varchar(10)");
        builder.HasOne(p=>p.User).WithOne(u=>u.Person).HasForeignKey<Users>(u=>u.PersonId);
    }
}