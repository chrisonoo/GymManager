using GymManager.Domain.Enums;

namespace GymManager.Domain.Entities;

public class TicketType
{
    public int Id { get; set; }
    public decimal Price { get; set; }
    public TicketTypeEnum TicketTypeEnum { get; set; }

    public ICollection<Ticket> Tickets { get; set; } = new HashSet<Ticket>();

    public ICollection<TicketTypeTranslation> Translations { get; set; } = new HashSet<TicketTypeTranslation>();
}