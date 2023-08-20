using EHR365.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR365.Domain.Entities
{
    public class MedicalRecord : AuditableBaseEntity
    {
        public Patient? Patient { get; set; }
        public Diagnoses? Diagnoses { get; set; }
        public SurgicalHistory? SurgicalHistory { get; set; }
    }
}
