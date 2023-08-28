using EHR365.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR365.Domain.Entities
{
    public class HosptialStaff : AuditableBaseEntity
    {
        [ForeignKey(nameof(Address))]
        public Guid AddresId { get; set; }

        [ForeignKey(nameof(Hospital))]
        public Guid HospitalId { get; set; }

        public Hospital? Hospital { get; set; }

        [Required(ErrorMessage ="First Name is a required field.")]
        [MaxLength(30, ErrorMessage ="Maximum length of First Name is 30.")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length of Last Name is 30.")]
        public string? LastName { get; set;}

        [Required(ErrorMessage = "Job Title is a required field.")]
        [MaxLength(50, ErrorMessage = "Maximum length of Job Title is 50.")]
        public string? JobTitle { get; set; }

        [Required(ErrorMessage = "Phone Number is a required field.")]
        [MaxLength(15, ErrorMessage = "Maximum length of Phone Number is 15.")]
        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        [MaxLength(100, ErrorMessage ="Maximum length for Email is 100 characters.")]
        public string Email { get; set; } = string.Empty;

        public Address? StaffAddress { get; set; }
        public ICollection<Appointment>? PatientAppointments { get; set; }
    }
}