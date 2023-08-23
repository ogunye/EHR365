using EHR365.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EHR365.Domain.Entities
{
    public class PatientInBed: AuditableBaseEntity
    {
        [ForeignKey("Patient")]        
        public Guid PatientId { get; set; }
        public Patient? Patient { get; set; }

        [ForeignKey("Bed")]
        public int BedId { get; set; }
        public BedInWard? Bed { get; set; }
    }
}