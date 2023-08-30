using System.ComponentModel.DataAnnotations.Schema;

namespace EHR365.Domain.Entities
{
    public class Ward
    {
        public int WardId { get; set; }
        public string? WardName { get; set; }

        [ForeignKey(nameof(Hospital))]
        public Guid HosptialId { get; set; }
        public virtual Hospital? Hospital { get; set; }

        public List<BedInWard>? Beds { get; set; }
    }
}