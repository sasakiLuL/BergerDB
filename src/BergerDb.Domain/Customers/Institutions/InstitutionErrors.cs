using BergerDb.Domain.Primitives.Errors;

namespace BergerDb.Domain.Customers.Institutions;

public static class InstitutionErrors
{
    public static readonly Error TooLong = new(
        "Institution.TooLong", 
        "The institution name is too long.");

    public static readonly Error InvalidFormat = new(
        "Institution.InvalidFormat", 
        "The institution name can not contain special symbols.");
}
