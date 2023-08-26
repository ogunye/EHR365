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
    internal sealed class MedicalStaffRepository : RepositoryBase<HosptialStaff>, IMedicalStaffRepository
    {
        public MedicalStaffRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateEmployeeForHosptial(Guid hosptialId, HosptialStaff employee)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployeeForHosptial(HosptialStaff employee)
        {
            throw new NotImplementedException();
        }

        public Task<HosptialStaff> GetEmployeeAsync(Guid hospitalId, Guid employeeId, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<HosptialStaff>> GetEmployeesAsync(Guid hospitalId, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
