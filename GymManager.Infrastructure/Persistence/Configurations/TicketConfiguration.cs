using GymManager.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManager.Infrastructure.Persistence.Configurations;

class TicketConfiguration : IEntityTypeConfiguration<Ticket>
{
    public void Configure(EntityTypeBuilder<Ticket> builder)
    {
        builder.ToTable("Tickets");

        builder.Property(x => x.UserId)
            .IsRequired();

        builder.Property(x => x.TicketTypeId)
            .HasDefaultValue(1);

        builder
            .HasOne(x => x.User)
            .WithMany(x => x.Tickets)
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(x => x.TicketType)
            .WithMany(x => x.Tickets)
            .HasForeignKey(x => x.TicketTypeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(x => x.Invoice)
            .WithOne(x => x.Ticket)
            .HasForeignKey<Invoice>(x => x.TicketId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}