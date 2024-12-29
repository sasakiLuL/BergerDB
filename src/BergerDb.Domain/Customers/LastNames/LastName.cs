using BergerDb.Domain.Primitives.Entities;
using BergerDb.Domain.Primitives.Results;
using System.Text.RegularExpressions;

namespace BergerDb.Domain.Customers.LastNames;

public record LastName(string Value) : ValueObject
{
    public static readonly int MaximumLength = 100;

    public static readonly Regex AllowedSymbolsPattern = new(@"^[\p{L}0-9 ,\.\/\\!@#$%&*+()_-]*$");

    public static Result<LastName> Create(string value)
    {
        return Validate(
            new LastNameValidator(),
            new LastName(value));
    }
}
