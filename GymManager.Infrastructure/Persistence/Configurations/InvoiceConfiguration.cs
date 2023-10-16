using GymManager.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManager.Infrastructure.Persistence.Configurations;

class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
{
    public void Configure(EntityTypeBuilder<Invoice> builder)
    {
        builder.ToTable("Invoices");

        builder.Property(x => x.MethodOfPayment)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(x => x.UserId)
            .IsRequired();

        builder.Property(x => x.TicketId)
            .IsRequired();

        builder
            .HasOne(x => x.User)
            .WithMany(x => x.Invoices)
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}