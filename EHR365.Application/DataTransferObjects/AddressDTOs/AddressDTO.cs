using System.ComponentModel.DataAnnotations;

namespace EHR365.Application.DataTransferObjects.AddressDTOs
{
    public record AddressDTO
    {
        public Guid Id { get; init; }
        public string? StreetAddress { get; init; }
        public string? City { get; init; }
        public string? PostalCode { get; init; }
        public string? Country { get; init; }
    }
}