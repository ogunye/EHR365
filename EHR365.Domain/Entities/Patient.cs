using EHR365.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR365.Domain.Entities
{
    public class Patient : AuditableBaseEntity
    {
        public string PatientNumber { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime DateofBirth { get; set; }
        public string Gender { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public Address? PatientAddress { get; set; }
        public ICollection<MedicalRecord>? MedicalRecords { get; set; }
        public ICollection<PatientDrugTreatment>? DrugTreatments { get; set; }
        public ICollection<PatientVitals>? Vitals { get; set; }
        public ICollection<DoctorsAssignedToPatient>? AssignedDoctors { get; set; }
        public PatientInBed? BedAssignment { get; set; }
    }
}
