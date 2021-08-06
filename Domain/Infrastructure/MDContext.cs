using Domain.Entities;
using Domain.Infrastructure.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Domain.Infrastructure
{
    public class MDContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<Clinica> Clinicas { get; set; }
        public DbSet<SpecialityClinica> SpecialityClinicas { get; set; }

        public MDContext(DbContextOptions<MDContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Seed();
        }
    }
}
