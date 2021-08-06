using Domain.Entities;
using Domain.Infrastructure;
using Services.Constants;
using Services.DTOs;
using System;
using System.Linq;
using System.Threading.Tasks;
using Services.Interfaces;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using AutoMapper;

namespace Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly MDContext _context;
        private readonly IMapper _mapper;

        public AppointmentService(MDContext context, IMapper mapper)
        {
            _context = context; 
            _mapper = mapper;
        }

        public async Task SetAppointment(AppointmentDTO dto)
        {
            var patient = _context.Patients.FirstOrDefault(x => x.Id == dto.PatientId);
            if (patient == null) throw new ArgumentException(AppointmentErrorMessages.PatientNotFound);

            var doctor = _context.Doctors.FirstOrDefault(x => x.Id == dto.DoctorId);
            if (doctor == null) throw new ArgumentException(AppointmentErrorMessages.DoctorNotFound);

            var clinica = _context.Clinicas.FirstOrDefault(x => x.Id == dto.ClinicaId);
            if (clinica == null) throw new ArgumentException(AppointmentErrorMessages.ClinicaNotFound);

            var appointment = new Appointment()
            {
                Date = dto.Date,
                Patient = patient,
                Doctor = doctor,
                Clinica = clinica
            };

            await _context.Appointments.AddAsync(appointment);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAppointment(Guid id)
        {
            var appointment = _context.Appointments.FirstOrDefault(x => x.Id == id);
            if (appointment == null) throw new ArgumentException(AppointmentErrorMessages.AppointmentNotFound);
            _context.Appointments.Remove(appointment);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTimeAppointment(UpdateAppointmentDTO dto)
        {
            var appointment = _context.Appointments.FirstOrDefault(x => x.Id == dto.Id);
            if (appointment == null) throw new ArgumentException(AppointmentErrorMessages.AppointmentNotFound);

            appointment.Date = dto.Date;
            await _context.SaveChangesAsync();
        }

        public List<AppointmentToFrontDTO> GetDoctorAppointments(Guid doctorId)
        {
            var doctor = _context.Doctors
                .Include(p => p.Appointments)
                .ThenInclude(a => a.Clinica)
                .Include(p => p.Appointments)
                .ThenInclude(a => a.Patient)
                .Include(d => d.Appointments).FirstOrDefault(x => x.Id == doctorId);
            if (doctor == null) throw new ArgumentException(AppointmentErrorMessages.DoctorNotFound);

            var appointments = doctor.Appointments;
            var result = new List<AppointmentToFrontDTO>();
            foreach (var appointment in appointments)
            {
                result.Add(_mapper.Map<AppointmentToFrontDTO>(appointment));
            }
            return result;
        }

        public List<AppointmentToFrontDTO> GetPatientAppointments(Guid patientId)
        {
            
            var patient = _context.Patients
                .Include(p => p.Appointments)
                .ThenInclude(a => a.Clinica)
                .Include(p => p.Appointments)
                .ThenInclude(a => a.Doctor)
                .FirstOrDefault(x => x.Id == patientId);
            if (patient == null) throw new ArgumentException(AppointmentErrorMessages.PatientNotFound);

            var appointments = patient.Appointments;
            var result = new List<AppointmentToFrontDTO>();
            foreach (var appointment in appointments)
            {
                result.Add(_mapper.Map<AppointmentToFrontDTO>(appointment));
            }
            return result;
        }
    }
}
