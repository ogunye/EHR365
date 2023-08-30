using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR365.Domain.Entities
{
    public class BedInWard
    {
        [Key]
        public int BedId { get; set; }

        [ForeignKey(nameof(Ward))]
        public int WardId { get; set; }
        public virtual Ward? Ward { get; set; }

        public int BedNumber { get; set; }
    }
}