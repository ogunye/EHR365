using EHR365.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR365.Domain.Entities
{
    public class Address : AuditableBaseEntity
    {
        [Required(ErrorMessage = "Street Address is a required field.")]
        [MaxLength(100, ErrorMessage = "Maximum length for Street Address  is 100")]
        public string StreetAddress { get; set; } = string.Empty;

        [Required(ErrorMessage = " City is a required field.")]
        [MaxLength(50, ErrorMessage = "Maximum length for City is 50")]
        public string City { get; set; } = string.Empty;

        [Required(ErrorMessage = " PostalCode is a required field.")]
        [MaxLength(10, ErrorMessage = "Maximum length for PostalCode is 10")]
        public string PostalCode { get; set; } = string.Empty;

        [MaxLength(30, ErrorMessage = "Maximum length for Country is 30")]
        public string Country { get; set; } = string.Empty;
    }
}
