using BergerDb.Domain.Primitives.Results;
using FluentValidation;

namespace BergerDb.Domain.Customers.FirstNames;

public class FirstNameValidator : AbstractValidator<FirstName>
{
    public FirstNameValidator()
    {
        RuleFor(p => p.Value)
            .MaximumLength(FirstName.MaximumLength)
                .WithError(FirstNameErrors.TooLong)
            .Matches(FirstName.AllowedSymbolsPattern)
                .WithError(FirstNameErrors.InvalidFormat);
    }
}
