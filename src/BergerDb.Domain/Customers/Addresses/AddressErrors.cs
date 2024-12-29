using BergerDb.Domain.Primitives.Errors;

namespace BergerDb.Domain.Customers.Addresses;

public static class AddressErrors
{
    public static readonly Error TooLong = new(
        "Address.TooLong", 
        "The address is too long.");

    public static readonly Error InvalidFormat = new(
        "Address.InvalidFormat", 
        "The address can not contain special symbols.");
}
