namespace GymManager.Domain.Entities;

public class TicketTypeTranslation
{
    public int Id { get; set; }
    public string Name { get; set; }

    public int LanguageId { get; set; }
    public Language Language { get; set; }

    public int TicketTypeId { get; set; }
    public TicketType TicketType { get; set; }
}