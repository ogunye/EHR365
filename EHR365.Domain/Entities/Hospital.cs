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
    public class Hospital : AuditableBaseEntity
    {
        [Required(ErrorMessage ="Hospital Name is a required field.")]
        [MaxLength(100, ErrorMessage ="Maximum length for Hosptial Name is 100")]
        public string HospitalName { get; set; } = string.Empty;

        [ForeignKey(nameof(Address))]
        public Guid AddressId { get; set; }
        public virtual Address? HospitalAddress { get; set; }
    }
}
