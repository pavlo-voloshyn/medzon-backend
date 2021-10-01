using AutoMapper;
using Domain.Entities;
using Domain.Infrastructure;
using Microsoft.AspNetCore.Identity;
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
    public class UserService : IUserService
    {
        private readonly MDContext _context;
        private readonly IMapper _mapper;

        public UserService(MDContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<DoctorToFrontDTO> GetDoctors()
        {
            var doctors = _context.Doctors.Include(x => x.Clinica).Include(x => x.Speciality).ToList();
            var result = new List<DoctorToFrontDTO>();
            
            foreach(var doctor in doctors)
            {
                result.Add(new DoctorToFrontDTO()
                {
                    Id = doctor.Id.ToString(),
                    FirstName = doctor.FirstName,
                    LastName = doctor.LastName,
                    Clinica = doctor.Clinica.Id.ToString(),
                    Rate = doctor.Rate,
                    Speciality = doctor.Speciality.Id.ToString()
                }); 
            }

            return result;
        } 

        public List<Speciality> GetDoctorSpecialties()
        {
            return _context.Specialities.ToList();
        }

        public List<SpecialityClinica> GetClinicaSpecialties()
        {
            return _context.SpecialityClinicas.ToList();
        }

        public List<Clinica> GetClinicas()
        {
            return _context.Clinicas.Include(x => x.Speciality).ToList();
        }

        public async Task<List<FeedbackToFrontDTO>> GetFeedbacksDoctor(Guid id)
        {
            var doctor = await _context.Doctors.Include(x => x.Feedbacks).ThenInclude(x => x.Patient).FirstOrDefaultAsync(x => x.Id == id);
            var feedbacks = new List<FeedbackToFrontDTO>();

            foreach(var feedback in doctor.Feedbacks)
            {
                feedbacks.Add(new FeedbackToFrontDTO()
                {
                    Content = feedback.Content,
                    Date = feedback.Date.ToString(),
                    DoctorId = feedback.DoctorId.ToString(),
                    PatientId = feedback.Patient.Id.ToString(),
                    Stars = feedback.Stars
                });
            }

            return feedbacks;
        }

        public async Task<string> GetUserId(string name)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.UserName == name);
            if (user == null) throw new ArgumentException("Not found user");

            return user.Id;
        }

        public async Task<string> GetPatientId(string name)
        {
            var patient = await _context.Patients.Include(p => p.User).FirstOrDefaultAsync(x => x.User.UserName == name);
            if (patient == null) throw new ArgumentException(AdminErrorMessages.PatientNotFound);

            return patient.Id.ToString();
        }
    }
}
