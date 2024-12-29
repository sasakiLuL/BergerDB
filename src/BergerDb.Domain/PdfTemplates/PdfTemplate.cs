using BergerDb.Domain.Primitives.Entities;
using System.Drawing;

namespace BergerDb.Domain.PdfTemplates;

public class PdfTemplate : Entity
{
    public PdfTemplate(
        PdfTemplateId id, 
        Color color) : base(id)
    {
        Color = color;
    }

    public Color Color { get; set; }
}
