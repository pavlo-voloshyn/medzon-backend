using Domain.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Services.Constants;
using Services.DTOs;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PatientService : IPatientService
    {
        private readonly MDContext _context;

        public PatientService(MDContext context)
        {
            _context = context;
        }

        public async Task AddFavotireDoctor(FavoriteDoctorDTO dto)
        {
            var patient = await _context.Patients.Include(x => x.Doctors).FirstOrDefaultAsync(x => x.Id == dto.PatientId);
            if (patient == null) throw new ArgumentException(AdminErrorMessages.PatientNotFound);

            var doctor = await _context.Doctors.FirstOrDefaultAsync(x => x.Id == dto.DoctorId);
            if (doctor == null) throw new ArgumentException(AdminErrorMessages.DoctorNotFound);

            patient.Doctors.Add(doctor);

            await _context.SaveChangesAsync();
        }

        public async Task RemoveFavotireDoctor(FavoriteDoctorDTO dto)
        {
            var patient = await _context.Patients.Include(x => x.Doctors).FirstOrDefaultAsync(x => x.Id == dto.PatientId);
            if (patient == null) throw new ArgumentException(AdminErrorMessages.PatientNotFound);

            var doctor = await _context.Doctors.FirstOrDefaultAsync(x => x.Id == dto.DoctorId);
            if (doctor == null) throw new ArgumentException(AdminErrorMessages.DoctorNotFound);

            patient.Doctors.Remove(doctor);

            await _context.SaveChangesAsync();
        }

        public async Task<List<string>> SeeFavoriteDoctors(Guid id)
        {
            var patient = await _context.Patients.Include(x => x.Doctors).FirstOrDefaultAsync(x => x.Id == id);
            if (patient == null) throw new ArgumentException(AdminErrorMessages.PatientNotFound);

            var result = new List<string>();
            foreach (var doctor in patient.Doctors)
            {
                result.Add(doctor.Id.ToString());
            }

            return result;
        }
    }
}
