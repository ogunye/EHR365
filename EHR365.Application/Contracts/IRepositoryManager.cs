using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR365.Application.Contracts
{
    public interface IRepositoryManager
    {
        IPatientRepository Patient {  get; }
        IHosptialRepository Hosptial { get; }
        IMedicalStaffRepository MedicalStaff { get; }

        Task SaveAsync();

    }
}
