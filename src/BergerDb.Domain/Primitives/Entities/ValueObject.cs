using BergerDb.Domain.Primitives.Results;
using FluentValidation;

namespace BergerDb.Domain.Primitives.Entities;

public record ValueObject
{
    protected static Result<TValue> Validate<TValue>(
        AbstractValidator<TValue> validator,
        TValue instance)
    {
        return validator
            .Validate(instance)
            .ToDomainResult(instance);
    }
}
