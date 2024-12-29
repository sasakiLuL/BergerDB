using BergerDb.Domain.Primitives.Results;
using FluentValidation;

namespace BergerDb.Domain.Customers.ZipCodes;

public class ZipCodeValidator : AbstractValidator<ZipCode>
{
    public ZipCodeValidator()
    {
        RuleFor(c => c.Value)
            .MaximumLength(ZipCode.MaximumLenght)
                .WithError(ZipCodeErrors.TooLong)
            .Matches(ZipCode.FormatPattern)
                .WithError(ZipCodeErrors.InvalidFormat);
    }
}
