using BergerDb.Domain.Primitives.Entities;
using BergerDb.Domain.Primitives.Results;

namespace BergerDb.Domain.Customers.Notations;

public record Notation(string Value) : ValueObject
{
    public static readonly int MaximumLength = 3000;

    public static Result<Notation> Create(string value)
    {
        return Validate(
            new NotationValidator(),
            new Notation(value));
    }
}
