using FluentValidation.Results;
using MediatR;

namespace FSD.Core;

public abstract class Command : Message, IRequest<ValidationResult>
{
    public DateTime Timestamp { get; private set; }
    public ValidationResult ValidationResult { get; set; }

    protected Command()
    {
        Timestamp = DateTime.UtcNow;
        ValidationResult = new ValidationResult();
    }

    public virtual bool EstaValido()
    {
        return ValidationResult.IsValid;
    }
}
