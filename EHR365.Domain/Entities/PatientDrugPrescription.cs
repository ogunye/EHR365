﻿using EHR365.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR365.Domain.Entities
{
    public class PatientDrugPrescription : AuditableBaseEntity
    {
        [ForeignKey(nameof(Patient))]
        public Guid PatientId { get; set; }
        public virtual Patient? Patient { get; set; }

        [ForeignKey(nameof(Drugs))]
        public int DrugsId { get; set; }
        public virtual Drugs? Drug { get; set; }

        [MaxLength(10, ErrorMessage ="Maximum length for Dosage is 10.")]
        public string Dosage { get; set; } = string.Empty;
        public int Frequency { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
