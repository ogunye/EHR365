using EHR365.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR.Service.Contractds
{
    public interface IHospitalService
    {
        Task<IEnumerable<Hospital>> GetAllHosptialsAsync(bool trackChanges);
        Task<Hospital> CreateHositalAsync(Hospital hospital);
        Task<Hospital> GetHospitalByIdAsync(Guid id, bool trackChanges);
        Task<IEnumerable<Hospital>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);
        Task DeleteHospitalAsync(Guid hospitalId, Hospital hospital, bool trackChanges);
        Task UpdateHospitalAsync(Guid hospitalId, Hospital hospital, bool trackChanges);
    }
}
