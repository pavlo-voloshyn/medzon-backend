using Domain.Entities;
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

        public async Task AddFeedbackToDoctor(DoctorFeedbackDTO dto)
        {
            var patient = await _context.Patients.FirstOrDefaultAsync(x => x.Id == dto.PatientId);
            if (patient == null) throw new ArgumentException(AdminErrorMessages.PatientNotFound);

            var doctor = await _context.Doctors.FirstOrDefaultAsync(x => x.Id == dto.DoctorId);
            if (doctor == null) throw new ArgumentException(AdminErrorMessages.DoctorNotFound);

            var feedback = new Feedback()
            {
                Content = dto.Content,
                Doctor = doctor,
                Date = DateTime.UtcNow,
                Patient = patient,
                Stars = dto.Stars
            };

            await _context.AddAsync(feedback);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteFeedbackToDoctor(Guid id)
        {
            var feedback = _context.Feedbacks.FirstOrDefault(x => x.Id == id);
            if (feedback == null) throw new ArgumentException(AdminErrorMessages.FeedbackNotFound);

            _context.Remove(feedback);
            await _context.SaveChangesAsync();
        }

        public async Task AddFeedbackToClinica(ClinicaFeedbackDTO dto)
        {
            var patient = await _context.Patients.FirstOrDefaultAsync(x => x.Id == dto.PatientId);
            if (patient == null) throw new ArgumentException(AdminErrorMessages.PatientNotFound);

            var clinica = await _context.Clinicas.FirstOrDefaultAsync(x => x.Id == dto.ClinicaId);
            if (clinica == null) throw new ArgumentException(AdminErrorMessages.ClinicaNotFound);

            var feedback = new ClinicaFeedback()
            {
                Content = dto.Content,
                Clinica = clinica,
                Date = DateTime.UtcNow,
                Patient = patient,
                Stars = dto.Stars
            };

            await _context.AddAsync(feedback);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteFeedbackToClinica(Guid id)
        {
            var feedback = _context.ClinicaFeedbacks.FirstOrDefault(x => x.Id == id);
            if (feedback == null) throw new ArgumentException(AdminErrorMessages.FeedbackNotFound);

            _context.Remove(feedback);
            await _context.SaveChangesAsync();
        }
    }
}
