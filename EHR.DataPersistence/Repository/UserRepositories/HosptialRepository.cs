using EHR.DataPersistence.Context;
using EHR365.Application.Contracts;
using EHR365.Domain.Entities;
using Microsoft.EntityFrameworkCore;
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

        public void CreateHospital(Hospital hospital) => Create(hospital);

        public void DeleteHospitalAsync(Hospital hospital) => Delete(hospital);

        public async Task<IEnumerable<Hospital>> GetAllHosptialsAsync(bool trackChanges) => await FindAll(trackChanges)
                .OrderByDescending(x => x.Id)
                .ToListAsync();

        public async Task<IEnumerable<Hospital>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges) => await FindByCondition(x => ids.Contains(x.Id), trackChanges)
                .ToListAsync();

        public async Task<Hospital> GetHospitalAsync(Guid id, bool trackChanges)
        {
           var hospital =  await FindByCondition(c => c.Id.Equals(id), trackChanges)
                 .SingleOrDefaultAsync();
            
            return hospital;
        }
    }
}
