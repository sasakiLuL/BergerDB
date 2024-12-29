using BergerDb.Domain.Customers.Emails;
using BergerDb.Domain.Primitives.Entities;
using BergerDb.Domain.Primitives.Results;
using System.Text.RegularExpressions;

namespace BergerDb.Domain.Customers.EmailAddresses;

public record EmailAddress(string Value) : ValueObject
{
    public static readonly int MaximumLength = 256;

    public static readonly Regex FormatPattern = new(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");

    public static Result<EmailAddress> Create(string value)
    {
        return Validate(
            new EmailAddressValidator(),
            new EmailAddress(value));
    }
}
