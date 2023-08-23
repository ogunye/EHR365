using EHR365.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR.DataPersistence.Context
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options) 
        {
            
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<BedInWard> BedInWards { get; set; }
        public DbSet<Clinic> Clinic { get; set; }
        public DbSet<Diagnoses> Diagnoses { get; set; }
        public DbSet<Drugs> Drugs { get; set; }
        public DbSet<HosptialStaff> Hosptials { get; set; }
        public DbSet<HosptialStaff> HosptialStaff { get; set; }
        
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientDrugPrescription> PatientDrugPrescriptions { get; set; }
        public DbSet<PatientInBed> PatientInBeds { get; set; }
        public DbSet<PatientVitals> PatientVitals { get; set; }
        public DbSet<SurgicalHistory> SurgicalHistories { get; set; }
        public DbSet<Ward> Wards { get; set; }
    }
}
