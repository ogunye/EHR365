using EHR365.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR365.Application.Contracts
{
    public interface IMedicalStaffRepository
    {
        Task<IEnumerable<HosptialStaff>> GetEmployeesAsync(Guid hospitalId, bool trackChanges);
        Task<HosptialStaff> GetEmployeeAsync(Guid hospitalId,  Guid employeeId, bool trackChanges);
        void CreateEmployeeForHosptial(Guid hosptialId, HosptialStaff employee);
        void DeleteEmployeeForHosptial(HosptialStaff employee);
    }
}
