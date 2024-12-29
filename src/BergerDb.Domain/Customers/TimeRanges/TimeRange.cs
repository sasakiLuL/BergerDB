using BergerDb.Domain.Customers.Prefixes;
using BergerDb.Domain.Primitives.Entities;
using BergerDb.Domain.Primitives.Results;

namespace BergerDb.Domain.Customers.TimeRanges;

public record TimeRange(DateTime? Start, DateTime? End) : ValueObject
{
    public static Result<TimeRange> Create(DateTime start, DateTime end)
    {
        return Validate(
            new TimeRangeValidator(),
            new TimeRange(start, end));
    }
}
