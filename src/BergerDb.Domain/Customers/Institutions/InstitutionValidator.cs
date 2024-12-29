using BergerDb.Domain.Primitives.Results;
using FluentValidation;

namespace BergerDb.Domain.Customers.Institutions;

public class InstitutionValidator : AbstractValidator<Institution>
{
    public InstitutionValidator()
    {
        RuleFor(p => p.Value)
            .MaximumLength(Institution.MaximumLength)
                .WithError(InstitutionErrors.TooLong)
            .Matches(Institution.AllowedSymbolsPattern)
                .WithError(InstitutionErrors.InvalidFormat);
    }
}
