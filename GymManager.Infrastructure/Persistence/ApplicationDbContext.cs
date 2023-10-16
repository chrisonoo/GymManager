using System.Reflection;

using GymManager.Application.Common.Interfaces;
using GymManager.Domain.Entities;
using GymManager.Infrastructure.Persistence.Extensions;

using Microsoft.EntityFrameworkCore;

using File = GymManager.Domain.Entities.File;

namespace GymManager.Infrastructure.Persistence;
public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Address> Addresses { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<EmployeeEvent> EmployeeEvents { get; set; }
    public DbSet<SettingsPosition> SettingsPositions { get; set; }
    public DbSet<Settings> Settings { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<TicketType> TicketTypes { get; set; }
    public DbSet<File> Files { get; set; }
    public DbSet<Announcement> Announcements { get; set; }
    public DbSet<Language> Languages { get; set; }
    public DbSet<TicketTypeTranslation> TicketTypeTranslations { get; set; }
    public DbSet<Invoice> Invoices { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        modelBuilder.SeedLanguage();
        modelBuilder.SeedTicketType();
        modelBuilder.SeedTicketTypeTranslation();
        modelBuilder.SeedSettings();
        modelBuilder.SeedSettingsPosition();
        modelBuilder.SeedAnnouncement();

        base.OnModelCreating(modelBuilder);
    }
}
