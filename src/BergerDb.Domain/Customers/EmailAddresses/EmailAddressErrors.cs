using BergerDb.Domain.Primitives.Errors;

namespace BergerDb.Domain.Customers.Emails;

public static class EmailAddressErrors
{
    public static readonly Error TooLong = new(
        "EmailAddress.TooLong", 
        "The email is too long.");

    public static readonly Error InvalidFormat = new(
        "EmailAddress.InvalidFormat", 
        "The email format is invalid.");
}
