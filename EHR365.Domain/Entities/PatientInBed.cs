using EHR365.Domain.Common;

namespace EHR365.Domain.Entities
{
    public class PatientInBed: AuditableBaseEntity
    {
        public Patient? Patient { get; set; }
        public BedInWard? Bed { get; set; }
    }
}