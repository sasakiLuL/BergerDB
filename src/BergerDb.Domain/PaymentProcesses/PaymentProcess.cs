using BergerDb.Domain.Customers;
using BergerDb.Domain.Emails;
using BergerDb.Domain.Payments;
using BergerDb.Domain.Primitives.Entities;
using BergerDb.Domain.Primitives.Results;

namespace BergerDb.Domain.PaymentProcesses;

public abstract class PaymentProcess : Entity
{
    protected readonly List<Email> _emails = [];

    protected PaymentProcess(
        PaymentProcessId id,
        PaymentType paymentType) : base(id)
    {
        PaymentType = paymentType;
    }

    public PaymentType PaymentType { get; init; }

    public Payment? Payment { get; protected set; }

    public virtual Result SendEmail(Email email)
    {
        _emails.Add(email);

        return Result.Success();
    }

    public virtual Result Finish(Payment payment)
    {
        Payment = payment;

        return Result.Success();
    }

    public virtual Result Cancel()
    {
        Payment = null;

        return Result.Success();
    }

    public virtual bool IsPending()
    {
        return Payment is null;
    }

    public virtual bool IsMade()
    {
        return !IsPending();
    }

    public abstract bool IsExpired();

    public IReadOnlyList<Email> Emails => _emails.AsReadOnly();
}
