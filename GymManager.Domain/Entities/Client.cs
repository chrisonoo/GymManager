namespace GymManager.Domain.Entities;

public class Client
{
    public int Id { get; set; }
    public bool IsPrivateAccount { get; set; }
    public string NipNumber { get; set; }

    public string UserId { get; set; }
    public ApplicationUser User { get; set; }
}