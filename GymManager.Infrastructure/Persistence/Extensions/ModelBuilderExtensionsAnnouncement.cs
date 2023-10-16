using GymManager.Domain.Entities;

using Microsoft.EntityFrameworkCore;


namespace GymManager.Infrastructure.Persistence.Extensions;
static class ModelBuilderExtensionsAnnouncement
{
    public static void SeedAnnouncement(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Announcement>().HasData(
            new Announcement
            {
                Id = 1,
                Date = new DateTime(2023, 1, 12),
                Description = "Kod promocyjny na suplementy w sklepie abc = rabat12."
            },
            new Announcement
            {
                Id = 2,
                Date = new DateTime(2023, 1, 15),
                Description = "W najbliższą niedzielę siłownia jest otwarta do godsziny 24:00."
            },
            new Announcement
            {
                Id = 3,
                Date = new DateTime(2023, 1, 16),
                Description = "Jutrzejsze zajęcia crossfit zostały odwołane - przepraszamy."
            },
            new Announcement
            {
                Id = 4,
                Date = new DateTime(2023, 1, 20),
                Description = "Zatrudnimy trenera personalnego."
            },
            new Announcement
            {
                Id = 5,
                Date = new DateTime(2023, 1, 24),
                Description = "Od przyszłego miesiąca możesz kupić karnet dla dwóch osób w cenie jednego."
            },
            new Announcement
            {
                Id = 6,
                Date = new DateTime(2022, 12, 7),
                Description = "Zatrudnimy recepcjonistę."
            },
            new Announcement
            {
                Id = 7,
                Date = new DateTime(2022, 12, 5),
                Description = "Kod promocyjny na suplementy w sklepie abc = rabat12."
            },
            new Announcement
            {
                Id = 8,
                Date = new DateTime(2022, 12, 4),
                Description = "W poprzednim miesiącu zrobiłeś aż 12 treningów - gratulacje."
            },
            new Announcement
            {
                Id = 9,
                Date = new DateTime(2022, 12, 3),
                Description = "Jutrzejsze zajęcia crossfit zostały odwołane - przepraszamy."
            },
            new Announcement
            {
                Id = 10,
                Date = new DateTime(2022, 12, 3),
                Description = "Kod promocyjny na suplementy w sklepie abc = rabat12."
            },
            new Announcement
            {
                Id = 11,
                Date = new DateTime(2022, 12, 2),
                Description = "Odbierz kod zniżkowy na suplementacje w recepcji."
            },
            new Announcement
            {
                Id = 12,
                Date = new DateTime(2022, 12, 1),
                Description = "Wesołych świąt."
            });
    }
}
