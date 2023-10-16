using GymManager.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManager.Infrastructure.Persistence.Configurations;

class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.ToTable("Employees");

        builder.Property(x => x.WebsiteUrl)
            .HasMaxLength(200)
            .IsUnicode(false);

        builder.Property(x => x.ImageUrl)
            .HasMaxLength(400);

        builder.Property(x => x.UserId)
            .IsRequired();
    }
}