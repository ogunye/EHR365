using EHR365.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR365.Domain.Entities
{
    public class Diagnoses : AuditableBaseEntity
    {
        
        [ForeignKey(nameof(Patient))]
        public Guid PatientId { get; set; }
        public virtual Patient? Patient { get; set; }

        [ForeignKey(nameof(HosptialStaff))]
        public Guid DoctorId { get; set; }

        public virtual HosptialStaff? AssignedDoctor { get; set; }

        [Required(ErrorMessage ="Diagnoses is a required field.")]
        [MaxLength(200, ErrorMessage = "Maximum length for Diagnosis Name is 200")]
        public string? DiagnosisName { get; set; }

        [Required(ErrorMessage = "Diagnoses Description is a required field.")]
        [MaxLength(1000, ErrorMessage = "Maximum length for Diagnosis Description is 1000")]
        public string? Description { get; set; }
    }
}