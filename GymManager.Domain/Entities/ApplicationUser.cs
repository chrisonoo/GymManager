namespace GymManager.Domain.Entities;
public class ApplicationUser
{
    public string Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime RegisterDateTime { get; set; }
    public bool IsDeleted { get; set; }

    public Address Address { get; set; }
    public Client Client { get; set; }
    public Employee Employee { get; set; }

    public ICollection<Ticket> Tickets { get; set; } = new HashSet<Ticket>();
    public ICollection<Invoice> Invoices { get; set; } = new HashSet<Invoice>();
    public ICollection<EmployeeEvent> EmployeeEvents { get; set; } = new HashSet<EmployeeEvent>();
}
