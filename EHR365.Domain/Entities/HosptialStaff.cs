using EHR365.Domain.Common;

namespace EHR365.Domain.Entities
{
    public class HosptialStaff : AuditableBaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set;}
        public string? JobTitle { get; set; }
        public string? PhoneNumber { get; set; }
        public string Email { get; set; } = string.Empty;
        public Address? StaffAddress { get; set; }
        public ICollection<Appointment>? PatientAppointments { get; set; }
    }
}