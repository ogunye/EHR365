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
        public virtual Patient? Patient { get; set; }

        [ForeignKey("DiagnoseId")]
        public virtual Diagnoses? Diagnoses { get; set; }

        [ForeignKey("SurgicalHistoryId")]
        public virtual SurgicalHistory? SurgicalHistory { get; set; }
    }
}
