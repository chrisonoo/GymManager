namespace GymManager.Domain.Entities;

public class Address
{
    public int Id { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string StreetNumber { get; set; }
    public string ZipCode { get; set; }

    public string UserId { get; set; }
    public ApplicationUser User { get; set; }
}