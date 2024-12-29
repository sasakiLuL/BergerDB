using BergerDb.Domain.Primitives.Results;
using FluentValidation;

namespace BergerDb.Domain.Customers.Notations;

public class NotationValidator : AbstractValidator<Notation>
{
    public NotationValidator()
    {
        RuleFor(n => n.Value)
            .MaximumLength(Notation.MaximumLength)
                .WithError(NotationErrors.TooLong);
    }
}
