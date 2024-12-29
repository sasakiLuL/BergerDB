using BergerDb.Domain.Primitives.Errors;

namespace BergerDb.Domain.Customers.TimeRanges;

public static class TimeRangeErrors
{
    public static Error ValueError => new(
        "TimeRange.ValueError", 
        "Wrong time range boundaries.");
}
