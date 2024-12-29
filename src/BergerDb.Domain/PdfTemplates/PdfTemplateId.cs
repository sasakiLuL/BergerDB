using BergerDb.Domain.Primitives.Entities;

namespace BergerDb.Domain.PdfTemplates;

public record PdfTemplateId(Guid Value) : EntityId(Value);
