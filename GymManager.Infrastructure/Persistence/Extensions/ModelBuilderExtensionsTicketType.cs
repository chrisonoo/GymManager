using GymManager.Domain.Entities;
using GymManager.Domain.Enums;

using Microsoft.EntityFrameworkCore;

namespace GymManager.Infrastructure.Persistence.Extensions;

static class ModelBuilderExtensionsTicketType
{
    public static void SeedTicketType(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TicketType>().HasData(
            new TicketType
            {
                Id = 1,
                Price = 10,
                TicketTypeEnum = TicketTypeEnum.Single
            },
            new TicketType
            {
                Id = 2,
                Price = 25,
                TicketTypeEnum = TicketTypeEnum.Weekly
            },
            new TicketType
            {
                Id = 3,
                Price = 100,
                TicketTypeEnum = TicketTypeEnum.Monthly
            },
            new TicketType
            {
                Id = 4,
                Price = 1000,
                TicketTypeEnum = TicketTypeEnum.Annual
            }
            );
    }
}