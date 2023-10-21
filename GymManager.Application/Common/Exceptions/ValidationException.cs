using FluentValidation.Results;

namespace GymManager.Application.Common.Exceptions;
public class ValidationException : Exception
{
    public ValidationException() : base("Błąd walidacji")
    {
        Errors = new Dictionary<string, string[]>();
    }

    public ValidationException(string description) : base(description)
    {
        Errors = new Dictionary<string, string[]>();
    }

    public ValidationException(IEnumerable<ValidationFailure> failures)
    {
        Errors = failures
            .GroupBy(x => x.PropertyName, x => x.ErrorMessage)
            .ToDictionary(failureGroup => failureGroup.Key, failureGroup => failureGroup.ToArray());
    }

    public IDictionary<string, string[]> Errors { get; set; }
}
