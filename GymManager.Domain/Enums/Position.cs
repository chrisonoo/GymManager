using System.ComponentModel.DataAnnotations;

namespace GymManager.Domain.Enums;
public enum Position
{
    [Display(Name = "Trener personalny")]
    Trainer,

    [Display(Name = "Recepcjonista/ka")]
    Receptionist,

    [Display(Name = "Asystent/ka")]
    Assistance
}
