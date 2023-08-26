using EHR.DataPersistence.Context;
using EHR.DataPersistence.Repository.UserRepositories;
using EHR365.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR.DataPersistence.Repository
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<IPatientRepository> _patientRepository;
        private readonly Lazy<IHosptialRepository> _hosptialRepository;
        private readonly Lazy<IMedicalStaffRepository> _medicalStaffRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;

            _patientRepository = new Lazy<IPatientRepository>(() => new 
            PatientRepository(repositoryContext));

            _hosptialRepository = new Lazy<IHosptialRepository>(() => new 
            HosptialRepository(repositoryContext));

            _medicalStaffRepository = new Lazy<IMedicalStaffRepository>(() => new 
            MedicalStaffRepository(repositoryContext));
        }
        public IPatientRepository Patient => _patientRepository.Value;

        public IHosptialRepository Hosptial => _hosptialRepository.Value;

        public IMedicalStaffRepository MedicalStaff => _medicalStaffRepository.Value;

        public async Task SaveAsync() => 
            await _repositoryContext.SaveChangesAsync();
    }
}
