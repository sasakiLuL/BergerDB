using BergerDb.Domain.Primitives.Entities;
using System.Text.RegularExpressions;

namespace BergerDb.Domain.Customers.Institutions;

public record Institution(string Value) : ValueObject
{
    public static readonly int MaximumLength = 100;

    public static readonly Regex AllowedSymbolsPattern = new(@"^[\p{L}0-9 ,\.\/\\!@#$%&*+()_-]*$");
}
