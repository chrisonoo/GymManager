using GymManager.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManager.Infrastructure.Persistence.Configurations;

class LanguageConfiguration : IEntityTypeConfiguration<Language>
{
    public void Configure(EntityTypeBuilder<Language> builder)
    {
        builder.ToTable("Languages");

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(x => x.Key)
            .IsRequired()
            .HasMaxLength(5);
    }
}