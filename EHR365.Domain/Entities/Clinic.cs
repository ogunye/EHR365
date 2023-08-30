using EHR365.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR365.Domain.Entities
{
    public class Clinic : AuditableBaseEntity
    {        
        public string ClinicName { get; set; } = string.Empty;

        [ForeignKey(nameof(Address))]
        public Guid AddressId { get; set; }
        public virtual Address? ClinicAddress { get; set; } 
    }
}
