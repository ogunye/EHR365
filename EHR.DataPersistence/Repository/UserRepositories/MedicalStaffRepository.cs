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
    internal sealed class MedicalStaffRepository : RepositoryBase<HosptialStaff>, IMedicalStaffRepository
    {
        public MedicalStaffRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateEmployeeForHosptial(Guid hosptialId, HosptialStaff employee)
        {
            employee.HospitalId = hosptialId;
            Create(employee);
        }

        public void DeleteEmployeeForHosptial(HosptialStaff employee) => Delete(employee);

        public async Task<HosptialStaff> GetEmployeeAsync(Guid hospitalId, Guid employeeId, bool trackChanges) =>
            await FindByCondition
            (c => c.HospitalId.Equals(hospitalId) &&
            c.Id.Equals(employeeId), trackChanges).SingleOrDefaultAsync();


        public async Task<IEnumerable<HosptialStaff>> GetEmployeesAsync(Guid hospitalId, bool trackChanges)
        {
            return await FindByCondition(e => e.HospitalId.Equals(hospitalId), trackChanges)
                .OrderBy(e => e.Id).ToListAsync();
        }
    }
}
