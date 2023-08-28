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
    internal sealed class PatientRepository : RepositoryBase<Patient>, IPatientRepository
    {
        public PatientRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreatePatient(Patient patient) => Create(patient);

        public void DeletePatient(Patient patient) => Delete(patient);

        public async Task<IEnumerable<Patient>> GetAllPatientsAsync(bool trackChanges) => await FindAll(trackChanges)
                .OrderBy(x => x.FirstName)
                .ToListAsync();

        public async Task<Patient> GetPatientByPatientNumberAsync(string patientNumber, bool trackChanges) =>
            await FindByCondition(expression: c => c.PatientNumber == patientNumber, trackChanges: trackChanges)
                .SingleOrDefaultAsync();
    }
}
