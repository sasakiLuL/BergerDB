using BergerDb.Domain.Customers;

namespace BergerDb.Domain.PaymentProcesses;

public class Debiting : PaymentProcess
{
    public Debiting(
        PaymentProcessId id) : base(
            id, 
            PaymentType.Debiting)
    {
    }

    public override bool IsExpired()
    {
        return IsPending();
    }
}
