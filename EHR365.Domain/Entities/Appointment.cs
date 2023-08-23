using EHR365.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR365.Domain.Entities
{
    public class Appointment : AuditableBaseEntity
    {
        [ForeignKey(nameof(Patient))]
        public Guid PatientId { get; set; }
        public Patient? Patient { get; set; }

        [ForeignKey(nameof(Hospital))]
        public Guid HospitalId { get; set; }

        public Hospital? Hospital { get; set; }

        [ForeignKey(nameof(Staff))]
        public Guid StaffId { get; set; }
        public HosptialStaff? Staff { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? AppointmentDate { get; set;}

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        public TimeSpan? AppointmentTime { get; set;}   

        [Required(ErrorMessage ="Appointment Type is a required field.")]
        [MaxLength(50, ErrorMessage ="Maximum length for Appointment Type is 50")]
        public string? AppointmentType {  get; set;} //Check-up, Procedure
    }
}
