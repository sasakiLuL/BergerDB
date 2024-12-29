using BergerDb.Domain.Primitives.Errors;

namespace BergerDb.Domain.Payments;

public static class PaymentErrors
{
    public static Error NotFound => new(
        "Payment.NotFound",
        "The payment with specified id was not found.");
}
