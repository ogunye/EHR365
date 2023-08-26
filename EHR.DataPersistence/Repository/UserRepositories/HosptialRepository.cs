using EHR.DataPersistence.Context;
using EHR365.Application.Contracts;
using EHR365.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR.DataPersistence.Repository.UserRepositories
{
    internal sealed class HosptialRepository : RepositoryBase<Hospital>, IHosptialRepository
    {
        public HosptialRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateHospital(Hospital hospital)
        {
            throw new NotImplementedException();
        }

        public void DeleteHospitalAsync(Hospital hospital)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Hospital>> GetAllHosptialsAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Hospital>> GetByIdsAsync(IEnumerable<Guid> guids, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Hospital> GetHospitalAsync(Guid id, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
