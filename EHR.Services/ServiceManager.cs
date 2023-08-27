using EHR.Service.Contractds;
using EHR365.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR.Services
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IPatientService> _patientService;
        private readonly Lazy<IHospitalService> _hospitalService;
        private readonly Lazy<IMedicalStaffService> _medicalStaffService;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger)
        {
            _patientService = new Lazy<IPatientService>(()=> new PatientService(repositoryManager, logger));
            _hospitalService = new Lazy<IHospitalService>(() => new HospitalService(repositoryManager, logger));
            _medicalStaffService = new Lazy<IMedicalStaffService>(() => new MedicalStaffService(repositoryManager, logger));
        }

        public IHospitalService HospitalService => _hospitalService.Value;

        public IPatientService PatientService => throw new NotImplementedException();

        public IMedicalStaffService MedicalStaffService => throw new NotImplementedException();
    }
}
