using BergerDb.Domain.Primitives.Results;
using FluentValidation;

namespace BergerDb.Domain.Customers.TimeRanges;

public class TimeRangeValidator : AbstractValidator<TimeRange>
{
    public TimeRangeValidator()
    {
        RuleFor(p => p.Start)
            .GreaterThanOrEqualTo(p => p.End)
            .When(p => p.End != null)
                .WithError(TimeRangeErrors.ValueError);
    }
}
