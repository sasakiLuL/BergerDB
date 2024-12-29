using BergerDb.Domain.Customers.Prefixes;
using BergerDb.Domain.Primitives.Entities;
using BergerDb.Domain.Primitives.Results;
using System.Text.RegularExpressions;

namespace BergerDb.Domain.Customers.FirstNames;

public record FirstName(string Value) : ValueObject
{
    public static readonly int MaximumLength = 100;

    public static readonly Regex AllowedSymbolsPattern = new(@"^[\p{L}0-9 ,\.\/\\!@#$%&*+()_-]*$");

    public static Result<FirstName> Create(string value)
    {
        return Validate(
            new FirstNameValidator(),
            new FirstName(value));
    }
}
