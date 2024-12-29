using BergerDb.Domain.Customers.Prefixes;
using BergerDb.Domain.Primitives.Entities;
using BergerDb.Domain.Primitives.Results;
using System.Text.RegularExpressions;

namespace BergerDb.Domain.Customers.Addresses;

public record Address(string Value) : ValueObject
{
    public static readonly int MaximumLength = 100;

    public static readonly Regex AllowedSymbolsPattern = new(@"^[\p{L}0-9, \\\.\/-]*$");

    public static Result<Address> Create(string value)
    {
        return Validate(
            new AddressValidator(),
            new Address(value));
    }
}
