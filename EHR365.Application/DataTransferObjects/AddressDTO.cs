using System.ComponentModel.DataAnnotations;

namespace EHR365.Application.DataTransferObjects
{
    public record AddressDTO
    {       
        public string? StreetAddress { get; init; }
        public string? City { get; init; }         
        public string? PostalCode { get; init; }
        public string? Country { get; init; }
    }
}