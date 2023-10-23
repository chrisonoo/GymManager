using System.ComponentModel.DataAnnotations;

using MediatR;

namespace GymManager.Application.Contacts.Commands.SendContactEmail;
public class SendContactEmailCommand : IRequest
{
    [Required(ErrorMessage = "Pole 'Imię i Nazwisko' jest wymagane.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Pole 'Adres e-mail' jest wymagane.")]
    [EmailAddress(ErrorMessage = "Pole 'Adres e-mail' nie jest prawidłowym adresem e-mail")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Pole 'Tytuł wiadomości' jest wymagane.")]
    public string Title { get; set; }

    [Required(ErrorMessage = "Pole 'Wiadomość' jest wymagane.")]
    public string Message { get; set; }

    public string AntySpamResult { get; set; }
}
