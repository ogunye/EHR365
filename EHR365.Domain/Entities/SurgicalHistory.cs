using EHR365.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR365.Domain.Entities
{
    public class SurgicalHistory: AuditableBaseEntity
    {
        [ForeignKey(nameof(Patient))]
        public Guid PatientId { get; set; }
        public virtual Patient? Patient { get; set; }

        [ForeignKey(nameof(Hospital))]
        public Guid  HospitalId { get; set; }
        public virtual Hospital? Hospital { get; set; }

        [Required(ErrorMessage = "Procedure Name is a required field.")]
        [MaxLength(100, ErrorMessage = "Maximum length for Procedure Name is 100 character.")]
        public string? ProcedureName { get; set; }

        public DateTime SurgeryDate { get; set; }

        [Required(ErrorMessage = "Surgeon Name is a required field.")]
        [MaxLength(100, ErrorMessage = "Maximum length for Surgeon Name is 100 character.")]
        public string? SurgeonName { get; set; }

        [MaxLength(500, ErrorMessage ="Maximum length for Complication is 500 characters.")]
        public string? Complications { get; set; }

        [MaxLength(500, ErrorMessage = "Maximum length for Notes is 500 characters.")]
        public string? Notes { get; set; }
    }
}