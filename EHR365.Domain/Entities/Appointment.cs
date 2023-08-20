using EHR365.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR365.Domain.Entities
{
    public class Appointment : AuditableBaseEntity
    {
        public Patient? Patient { get; set; }
        public Clinic? Clinic { get; set; }
        public Hospital? Hospital { get; set; }
        public HosptialStaff? Staff { get; set; }
        public DateTime? AppointmentDate { get; set;}
        public string? AppointmentType {  get; set;} //Check-up, Procedure
    }
}
