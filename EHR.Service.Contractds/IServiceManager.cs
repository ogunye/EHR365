using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR.Service.Contractds
{
    public interface IServiceManager
    {
        IHospitalService HospitalService { get; }
        IPatientService PatientService { get; }
        IMedicalStaffService MedicalStaffService { get; }
    }
}
