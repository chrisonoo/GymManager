using GymManager.Application.Common.Interfaces;

using MediatR;

namespace GymManager.Application.Contacts.Commands.SendContactEmail;

public class SendContactEmailCommandHandler : IRequestHandler<SendContactEmailCommand>
{
    private readonly IEmail _email;

    public SendContactEmailCommandHandler(IEmail email)
    {
        _email = email;
    }

    public async Task<Unit> Handle(SendContactEmailCommand request, CancellationToken cancellationToken)
    {
        var body = $"Nazwa: {request.Name}.<br /></br >E-mail nadawcy: {request.Email}.<br /><br />Tytuł wiadomości: {request.Title}.<br /><br />Wiadomość: {request.Message}.<br /><br />Wysłano z: GymManager.";

        await _email.SendAsync(
           $"Wiadomość z GymManager: {request.Title}",
           body,
          "chris@onoo.no");

        return Unit.Value;
    }
}