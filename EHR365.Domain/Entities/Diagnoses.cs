using EHR365.Domain.Common;

namespace EHR365.Domain.Entities
{
    public class Diagnoses : AuditableBaseEntity
    {
        public string? DiagnosisName { get; set; }
        public string? Description { get; set; }
    }
}