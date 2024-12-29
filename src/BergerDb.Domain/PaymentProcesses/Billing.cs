using BergerDb.Domain.Customers;
using BergerDb.Domain.Emails;
using BergerDb.Domain.Primitives.Time;

namespace BergerDb.Domain.PaymentProcesses;

public class Billing : PaymentProcess
{
    public const int TimeToPayInDays = 14;

    public Billing(
        PaymentProcessId id) : base(
            id, 
            PaymentType.Billing)
    {
    }

    public override bool IsExpired()
    {
        if (Payment is not null)
        {
            return false;
        }

        var lastInvoice = _emails
            .Where(e => e.EmailType is EmailType.Invoice)
            .MaxBy(e => e.SentOnUtc);

        if (lastInvoice is null)
        {
            return false;
        }

        return (lastInvoice.SentOnUtc - SystemTimeProvider.UtcNow).Days > TimeToPayInDays;
    }
}
