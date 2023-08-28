using EHR.Service.Contractds;
using EHR365.Application.Contracts;
using EHR365.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR.Services
{
    internal sealed class HospitalService : IHospitalService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        public HospitalService(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public Task<Hospital> CreateHositalAsync(Hospital hospital)
        {
            throw new NotImplementedException();
        }

        public Task DeleteHospitalAsync(Guid hospitalId, Hospital hospital, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Hospital>> GetAllHosptialsAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Hospital>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Hospital> GetHospitalByIdAsync(Guid id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task UpdateHospitalAsync(Guid hospitalId, Hospital hospital, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
