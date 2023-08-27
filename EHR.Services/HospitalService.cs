using EHR.Service.Contractds;
using EHR365.Application.Contracts;
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
    }
}
