using BergerDb.Domain.Primitives.Entities;

namespace BergerDb.Domain.Emails;

public record EmailId(Guid Value) : EntityId(Value);
