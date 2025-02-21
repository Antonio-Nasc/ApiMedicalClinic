using ApiMedicalClinic.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiMedicalClinic.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Patient> Patients { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Address> Addresss { get; set; }
    public DbSet<MedicalRecord> MedicalRecords { get; set; }
    public DbSet<Consultation> Consultations { get; set; }
    public DbSet<Prescription> Prescriptions { get; set; }
    public DbSet<Specialization> Specializations { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Invoicing> Invoicings { get; set; }

}
