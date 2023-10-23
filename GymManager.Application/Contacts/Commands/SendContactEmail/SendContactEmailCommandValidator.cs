using FluentValidation;


namespace GymManager.Application.Contacts.Commands.SendContactEmail;
public class SendContactEmailCommandValidator : AbstractValidator<SendContactEmailCommand>
{
    //public SendContactEmailCommandValidator()
    //{
    //    RuleFor(x => x.Name)
    //        .NotEmpty().WithMessage("Pole 'Imię i Nazwisko' jest wymagane.");
    //}
}
