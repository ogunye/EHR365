using System.ComponentModel.DataAnnotations.Schema;

namespace EHR365.Domain.Entities
{
    public class BedInWard
    {
        public int BedId { get; set; }
        [ForeignKey(nameof(Ward))]
        public Guid WardId { get; set; }

        public Ward? Ward { get; set; }

        public int BedNumber { get; set; }
    }
}