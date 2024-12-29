using BergerDb.Domain.Primitives.Errors;

namespace BergerDb.Domain.Customers.FirstNames;

public static class FirstNameErrors
{
    public static readonly Error TooLong = new(
        "FirstName.TooLong", 
        "The firstname is too short.");

    public static readonly Error InvalidFormat = new(
        "FirstName.InvalidFormat", 
        "The firstname can contain only letters.");
}
