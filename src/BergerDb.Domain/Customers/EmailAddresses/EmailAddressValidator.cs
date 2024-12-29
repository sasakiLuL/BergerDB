using BergerDb.Domain.Customers.EmailAddresses;
using BergerDb.Domain.Primitives.Results;
using FluentValidation;

namespace BergerDb.Domain.Customers.Emails;

public class EmailAddressValidator : AbstractValidator<EmailAddress>
{
    public EmailAddressValidator()
    {
        RuleFor(p => p.Value)
            .MaximumLength(EmailAddress.MaximumLength)
                .WithError(EmailAddressErrors.TooLong)
            .Matches(EmailAddress.FormatPattern)
                .WithError(EmailAddressErrors.InvalidFormat);
    }
}
