namespace GymManager.Domain.Entities;

public class EmployeeEvent
{
    public int Id { get; set; }
    public DateTime Start { get; set; }
    public DateTime? End { get; set; }
    public bool IsFullDay { get; set; }
    public DateTime CreatedDate { get; set; }

    public string UserId { get; set; }
    public ApplicationUser User { get; set; }
}