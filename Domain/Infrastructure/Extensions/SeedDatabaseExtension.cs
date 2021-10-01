using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Infrastructure.Extensions
{
    public static class SeedDatabaseExtension
    {
        public static void Seed(this ModelBuilder builder)
        {

            builder.Entity<IdentityRole>()
                .HasData
                (
                    new IdentityRole()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "User",
                        NormalizedName = "USER"
                    },
                    new IdentityRole()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Admin",
                        NormalizedName = "ADMIN"
                    },
                    new IdentityRole()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Doctor",
                        NormalizedName = "DOCTOR"
                    }
                );
            builder.Entity<SpecialityClinica>()
                .HasData
                (
                    new SpecialityClinica() { Id = Guid.NewGuid(), Name = "Allergy and immunology" },
                    new SpecialityClinica() { Id = Guid.NewGuid(), Name = "Anesthesiology" },
                    new SpecialityClinica() { Id = Guid.NewGuid(), Name = "Dermatology" },
                    new SpecialityClinica() { Id = Guid.NewGuid(), Name = "Diagnostic radiology" },
                    new SpecialityClinica() { Id = Guid.NewGuid(), Name = "Family medicine" },
                    new SpecialityClinica() { Id = Guid.NewGuid(), Name = "Internal medicine" },
                    new SpecialityClinica() { Id = Guid.NewGuid(), Name = "Medical genetics" },
                    new SpecialityClinica() { Id = Guid.NewGuid(), Name = "Neurology" },
                    new SpecialityClinica() { Id = Guid.NewGuid(), Name = "Nuclear medicine" },
                    new SpecialityClinica() { Id = Guid.NewGuid(), Name = "Obstetrics and gynecology" },
                    new SpecialityClinica() { Id = Guid.NewGuid(), Name = "Ophthalmology" },
                    new SpecialityClinica() { Id = Guid.NewGuid(), Name = "Pathology" },
                    new SpecialityClinica() { Id = Guid.NewGuid(), Name = "Pediatrics" },
                    new SpecialityClinica() { Id = Guid.NewGuid(), Name = "Physical medicine and rehabilitation" },
                    new SpecialityClinica() { Id = Guid.NewGuid(), Name = "Preventive medicine" },
                    new SpecialityClinica() { Id = Guid.NewGuid(), Name = "Surgery" },
                    new SpecialityClinica() { Id = Guid.NewGuid(), Name = "Radiation oncology" },
                    new SpecialityClinica() { Id = Guid.NewGuid(), Name = "Urology" }

                );
            builder.Entity<Speciality>()
                .HasData
                (
                    new Speciality() { Id = Guid.NewGuid(), Name = "Immunolog" },
                    new Speciality() { Id = Guid.NewGuid(), Name = "Anesthesiolog" },
                    new Speciality() { Id = Guid.NewGuid(), Name = "Dermatolog" },
                    new Speciality() { Id = Guid.NewGuid(), Name = "Diagnostic radiolog" },
                    new Speciality() { Id = Guid.NewGuid(), Name = "Family doctor" },
                    new Speciality() { Id = Guid.NewGuid(), Name = "Neurolog" },
                    new Speciality() { Id = Guid.NewGuid(), Name = "Gynecolog" },
                    new Speciality() { Id = Guid.NewGuid(), Name = "Ophthalmolog" },
                    new Speciality() { Id = Guid.NewGuid(), Name = "Patholog" },
                    new Speciality() { Id = Guid.NewGuid(), Name = "Pediatr" },
                    new Speciality() { Id = Guid.NewGuid(), Name = "Physical medic and rehabilitolog" },
                    new Speciality() { Id = Guid.NewGuid(), Name = "Preventive medicine" },
                    new Speciality() { Id = Guid.NewGuid(), Name = "Surger" },
                    new Speciality() { Id = Guid.NewGuid(), Name = "Oncolog" },
                    new Speciality() { Id = Guid.NewGuid(), Name = "Urolog" }

    );
        }
    }
}
