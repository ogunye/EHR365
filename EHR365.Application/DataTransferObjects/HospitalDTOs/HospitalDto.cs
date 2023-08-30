using EHR365.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EHR365.Application.DataTransferObjects.AddressDTOs;

namespace EHR365.Application.DataTransferObjects.HospitalDTOs
{
    public record HospitalDto
    {
        public Guid Id { get; init; }
        public string? HopstialName { get; init; }

        public Guid AddressId { get; init; }
        public AddressDTO? HospitalAddress { get; init; }
    }
}
