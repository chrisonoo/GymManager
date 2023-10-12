using MediatR;

namespace GymManager.Application.Tickets.Queries.GetTicketById;
public class GetTicketByIdQuery : IRequest<TicketDto>
{
    public int Id { get; set; }
}
