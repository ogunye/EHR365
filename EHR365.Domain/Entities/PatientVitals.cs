using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR365.Domain.Entities
{
    public class PatientVitals
    {
        [ForeignKey(nameof(Patient))]
        public Guid PatientId { get; set; }

        public Patient? Patient { get; set; }       
        public Hospital? Hospital { get; set; }
        public DateTime? RecordCreated { get; set; } = DateTime.Now;
        public int? HeartRate { get; set; }

        [MaxLength(10, ErrorMessage ="Maximum length for Blood Pressure is 10.")]
        public string? BloodPressure { get; set; }
        public double? PatientTemperature { get; set; }
        public double? Weight { get; set; }
        public double? Height { get; set; }
    }
}
