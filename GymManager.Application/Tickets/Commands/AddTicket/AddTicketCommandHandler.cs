using MediatR;

using Microsoft.Extensions.Logging;

namespace GymManager.Application.Tickets.Commands.AddTicket;
public class AddTicketCommandHandler : IRequestHandler<AddTicketCommand>
{
    private readonly ILogger<AddTicketCommandHandler> _logger;

    public AddTicketCommandHandler(ILogger<AddTicketCommandHandler> logger)
    {
        _logger = logger;
    }
    public async Task<Unit> Handle(AddTicketCommand request, CancellationToken cancellationToken)
    {
        /*
        var ticket = new Tickets();
        ticket.name = request.Name;
        // Save to database
        */

        _logger.LogInformation("***** Log Information from AddTicketCommandHandler *****");
        _logger.LogError(new Exception("***** Log Error from AddTicketCommandHandler *****"), null);

        return Unit.Value;
    }
}
