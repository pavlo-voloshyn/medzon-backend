using Domain.Entities;
using Services.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IUserService
    {
        List<DoctorToFrontDTO> GetDoctors();
        List<Speciality> GetDoctorSpecialties();
        List<SpecialityClinica> GetClinicaSpecialties();
        List<Clinica> GetClinicas();
        Task<List<FeedbackToFrontDTO>> GetFeedbacksDoctor(Guid id);
        Task<string> GetUserId(string name);
        Task<string> GetPatientId(string name);
    }
}
