using AutoMapper;
using Domain.Entities;
using Domain.Infrastructure;
using Microsoft.EntityFrameworkCore;
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
    }
}
