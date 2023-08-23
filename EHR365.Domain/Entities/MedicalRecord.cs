using EHR365.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR365.Domain.Entities
{
    public class MedicalRecord : AuditableBaseEntity
    {
        [ForeignKey("PatientId")]
        public Patient? Patient { get; set; }

        [ForeignKey("DiagnoseId")]
        public Diagnoses? Diagnoses { get; set; }

        [ForeignKey("SurgicalHistoryId")]
        public SurgicalHistory? SurgicalHistory { get; set; }
    }
}
