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
    public class Patient : AuditableBaseEntity
    {
        [ForeignKey(nameof(Address))]
        public Guid AddressId { get; set; }



        [Required(ErrorMessage = "Patient Number is a required field.")]
        [MaxLength(8, ErrorMessage = "Maximum length of First Name is 8.")]
        public string PatientNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "First Name is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length of First Name is 30.")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Surname is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length of Surname is 30.")]
        public string LastName { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime DateofBirth { get; set; }

        [Required(ErrorMessage = "Gender is a required field.")]
        [MaxLength(6, ErrorMessage = "Maximum length of Gender is 6.")]
        public string Gender { get; set; } = string.Empty;

        [Required(ErrorMessage = "Phone Number is a required field.")]
        [MaxLength(15, ErrorMessage = "Maximum length of Phone Number is 15.")]
        public string PhoneNumber { get; set; } = string.Empty;

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;

        public Address? PatientAddress { get; set; }
        public ICollection<MedicalRecord>? MedicalRecords { get; set; }
        public ICollection<PatientDrugPrescription>? DrugTreatments { get; set; }
        public ICollection<PatientVitals>? Vitals { get; set; }
        public ICollection<Appointment>? DoctorAppointments { get; set; }
        public PatientInBed? BedAssignment { get; set; }
    }
}
