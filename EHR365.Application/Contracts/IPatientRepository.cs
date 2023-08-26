using EHR365.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR365.Application.Contracts
{
    public interface IPatientRepository
    {
        Task<IEnumerable<Patient>> GetAllPatientsAsync(bool trackChanges);
        Task<Patient> GetPatientByPatientNumberAsync(string patientNumber, bool trackChanges);
        Patient CreatePatient(Patient patient);
        Patient DeletePatient(Patient patient); // implement soft delete 
    }
}
