using GymManager.Domain.Enums;

namespace GymManager.Domain.Entities;

public class Employee
{
    public int Id { get; set; }
    public DateTime DateOfEmployment { get; set; }
    public DateTime? DateOfDismissal { get; set; }
    public decimal Salary { get; set; }
    public Position Position { get; set; }
    public string ImageUrl { get; set; }
    public string WebsiteUrl { get; set; }
    public string WebsiteRaw { get; set; }

    public string UserId { get; set; }
    public ApplicationUser User { get; set; }
}