using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR365.Domain.Entities
{
    public class PatientVitals
    {
        public Patient? Patient { get; set; }
        public Clinic? Clinic { get; set; }
        public Hospital? Hospital { get; set; }
        public DateTime? RecordCreated { get; set; } = DateTime.Now;
        public int? HeartRate { get; set; }
        public string? BloodPressure { get; set; }
        public double? PatientTemperature { get; set; }
        public double? Weight { get; set; }
        public double? Height { get; set; }
    }
}
