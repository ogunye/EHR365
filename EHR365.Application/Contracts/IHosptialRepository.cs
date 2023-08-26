using EHR365.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR365.Application.Contracts
{
    public interface IHosptialRepository
    {
        Task<IEnumerable<Hospital>> GetAllHosptialsAsync(bool trackChanges);
        Task<Hospital> GetHospitalAsync(Guid id, bool trackChanges);
        Task<IEnumerable<Hospital>> GetByIdsAsync(IEnumerable<Guid> guids, bool trackChanges);
        void CreateHospital(Hospital hospital);
        void DeleteHospitalAsync(Hospital hospital); //Implement soft delete
    }
}
