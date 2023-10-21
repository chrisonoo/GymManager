namespace GymManager.UI.Models;

public class MediatorValideteResponse<T>
{
    public bool IsValid { get; set; }
    public T Model { get; set; }
}