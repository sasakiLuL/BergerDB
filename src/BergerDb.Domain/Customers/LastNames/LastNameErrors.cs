using BergerDb.Domain.Primitives.Errors;

namespace BergerDb.Domain.Customers.LastNames;

public static class LastNameErrors
{
    public static readonly Error TooLong = new(
        "LastName.TooLong", 
        "The lastname is too short.");

    public static readonly Error InvalidFormat = new(
        "LastName.InvalidFormat", 
        "The lastname can contain only letters.");
}
