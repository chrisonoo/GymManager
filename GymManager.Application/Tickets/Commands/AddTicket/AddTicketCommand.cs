using MediatR;

namespace GymManager.Application.Tickets.Commands.AddTicket;
public class AddTicketCommand : IRequest
{
    public string Name { get; set; }
}
