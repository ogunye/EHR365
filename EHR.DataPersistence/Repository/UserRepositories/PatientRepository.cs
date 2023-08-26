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
    internal sealed class PatientRepository : RepositoryBase<Patient>, IPatientRepository
    {
        public PatientRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public Patient CreatePatient(Patient patient)
        {
            throw new NotImplementedException();
        }

        public Patient DeletePatient(Patient patient)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Patient>> GetAllPatientsAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Patient> GetPatientByPatientNumberAsync(string patientNumber, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
