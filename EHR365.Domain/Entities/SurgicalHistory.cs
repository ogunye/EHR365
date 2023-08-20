using EHR365.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR365.Domain.Entities
{
    public class SurgicalHistory: AuditableBaseEntity
    {
        [ForeignKey(nameof(Patient))]
        public Guid PatientId { get; set; }
        public Patient? Patient { get; set; }

        [ForeignKey(nameof(Hospital))]
        public Guid  HospitalId { get; set; }
        public Hospital? Hospital { get; set; }


        public string? ProcedureName { get; set; }
        public DateTime SurgeryDate { get; set; }
        public string? SurgeonName { get; set; }
        public string? Complications { get; set; }
        public string? Notes { get; set; }
    }
}