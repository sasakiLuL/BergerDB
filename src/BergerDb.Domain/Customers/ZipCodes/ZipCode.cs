using BergerDb.Domain.Primitives.Entities;
using BergerDb.Domain.Primitives.Results;
using System.Text.RegularExpressions;

namespace BergerDb.Domain.Customers.ZipCodes;

public record ZipCode(string Value) : ValueObject
{
    public static readonly int MaximumLenght = 5;

    public static readonly Regex FormatPattern = new(@"^[\d]+$");

    public static Result<ZipCode> Create(string value)
    {
        return Validate(
            new ZipCodeValidator(),
            new ZipCode(value));
    }
}
