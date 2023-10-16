using GymManager.Domain.Entities;

using Microsoft.EntityFrameworkCore;

namespace GymManager.Infrastructure.Persistence.Extensions;

static class ModelBuilderExtensionsLanguage
{
    public static void SeedLanguage(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Language>().HasData(
            new Language
            {
                Id = 1,
                Name = "Polski",
                Key = "pl"
            },
            new Language
            {
                Id = 2,
                Name = "Angielski",
                Key = "en"
            });
    }
}
