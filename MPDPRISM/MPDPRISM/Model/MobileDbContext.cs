using DataObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MPDPRISM.Model
{
    class MobileDbContext : DbContext
    {
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Diagnostic> Diagnostics { get; set; }
        public DbSet<DoctorHospital> DoctorHospitals { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Illness> Illnesss { get; set; }
        public DbSet<IllnessSymptom> IllnessSymptoms { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Symptom> Symptoms { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
    }
}
