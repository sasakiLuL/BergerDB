using BergerDb.Domain.Customers.EmailAddresses;
using BergerDb.Domain.PdfMetadatas;
using BergerDb.Domain.Primitives.Entities;

namespace BergerDb.Domain.Emails;

public class Email : Entity
{
    public Email(
        EntityId id, 
        EmailType emailType, 
        DateTime sentOnUtc) : base(id)
    {
        EmailType = emailType;
        SentOnUtc = sentOnUtc;
    }

    public EmailType EmailType { get; set; }

    public DateTime SentOnUtc { get; set; }

    public string Subject { get; set; }

    public EmailAddress From { get; set; }

    public EmailAddress To { get; set; }

    public string BodyText { get; set; }

    public PdfMetadata PdfMetadata { get; set; }
}
