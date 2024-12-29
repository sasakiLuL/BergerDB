using BergerDb.Domain.Customers.Addresses;
using BergerDb.Domain.Customers.EmailAddresses;
using BergerDb.Domain.Customers.FirstNames;
using BergerDb.Domain.Customers.Institutions;
using BergerDb.Domain.Customers.LastNames;
using BergerDb.Domain.Customers.Notations;
using BergerDb.Domain.Customers.Prefixes;
using BergerDb.Domain.Customers.ZipCodes;
using BergerDb.Domain.PaymentProcesses;
using BergerDb.Domain.Primitives.Entities;

namespace BergerDb.Domain.Customers;

public abstract class Customer : Entity
{
    private readonly List<PaymentProcess> _paymentProcesses = [];

    public Customer(
        CustomerId id,
        Address address,
        EmailAddress email,
        FirstName firstName,
        LastName lastName,
        Institution institution,
        Notation notation,
        Prefix prefix,
        ZipCode zipCode,
        EntryType entryType,
        MemberType memberType,
        PaymentType paymentType,
        Sex sex,
        decimal subscriptionCost,
        DateTime registeredOnUtc) : base(id)
    {
        Address = address;
        Email = email;
        FirstName = firstName;
        LastName = lastName;
        Institution = institution;
        Notation = notation;
        Prefix = prefix;
        ZipCode = zipCode;
        EntryType = entryType;
        MemberType = memberType;
        PaymentType = paymentType;
        Sex = sex;
        SubscriptionCost = subscriptionCost;
        RegisteredOnUtc = registeredOnUtc;
    }

    public Address Address { get; set; }

    public EmailAddress Email { get; set; }

    public FirstName FirstName { get; set; }

    public LastName LastName { get; set; }

    public Institution Institution { get; set; }

    public Notation Notation { get; set; }

    public Prefix Prefix { get; set; }

    public ZipCode ZipCode { get; set; }

    public EntryType EntryType { get; set; }

    public MemberType MemberType { get; set; }

    public decimal SubscriptionCost { get; set; }

    public DateTime RegisteredOnUtc { get; set; }

    public DateTime? TerminatedOnUtc { get; set; }

    public Sex Sex { get; set; }

    public PaymentType PaymentType { get; private set; }

    public bool IsActive()
    {
        return TerminatedOnUtc.HasValue;
    }

    public PaymentProcess? CurrentPaymentProcess => _paymentProcesses.LastOrDefault();

    public IReadOnlyList<PaymentProcess> PaymentProcesses => _paymentProcesses.AsReadOnly();
}
