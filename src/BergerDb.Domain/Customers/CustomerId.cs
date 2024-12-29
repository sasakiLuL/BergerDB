using BergerDb.Domain.Primitives.Entities;

namespace BergerDb.Domain.Customers;

public record CustomerId(Guid Value) : EntityId(Value);
