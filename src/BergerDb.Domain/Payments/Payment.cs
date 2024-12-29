using BergerDb.Domain.Primitives.Entities;

namespace BergerDb.Domain.Payments;

public class Payment : Entity
{
    protected Payment(
        PaymentId id,
        decimal value,
        DateTime payedOnUtc) : base(id)
    {
        Value = value;
        PayedOnUtc = payedOnUtc;
    }

    public decimal Value { get; set; }

    public DateTime PayedOnUtc { get; set; }
}
