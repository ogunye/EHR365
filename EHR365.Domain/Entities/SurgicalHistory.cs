using EHR365.Domain.Common;

namespace EHR365.Domain.Entities
{
    public class SurgicalHistory: AuditableBaseEntity
    {
        public Patient? Patient { get; set; }
        public Hospital? Hospital { get; set; }
        public string? ProcedureName { get; set; }
        public DateTime SurgeryDate { get; set; }
        public string? SurgeonName { get; set; }
        public string? Complications { get; set; }
        public string? Notes { get; set; }
    }
}