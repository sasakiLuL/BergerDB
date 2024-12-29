using BergerDb.Domain.Primitives.Results;
using FluentValidation;

namespace BergerDb.Domain.Customers.LastNames;

public class LastNameValidator : AbstractValidator<LastName>
{
    public LastNameValidator()
    {
        RuleFor(p => p.Value)
            .MaximumLength(LastName.MaximumLength)
                .WithError(LastNameErrors.TooLong)
            .Matches(LastName.AllowedSymbolsPattern)
                .WithError(LastNameErrors.InvalidFormat);
    }
}
