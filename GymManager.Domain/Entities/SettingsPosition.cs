using GymManager.Domain.Enums;

namespace GymManager.Domain.Entities;
public class SettingsPosition
{
    public int Id { get; set; }
    public string Key { get; set; }
    public string Value { get; set; }
    public string Description { get; set; }
    public SettingsType Type { get; set; }
    public int Order { get; set; }
    public int SettingsId { get; set; }
    public Settings Settings { get; set; }
}
