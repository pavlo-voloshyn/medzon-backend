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
    public class AdminService : IAdminService
    {
        private readonly MDContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<IdentityUser> _userManager;

        public AdminService(MDContext context, IMapper mapper, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task AddDoctor(FreshDoctorDTO dto)
        {
            var user = _mapper.Map<IdentityUser>(dto);
            user.EmailConfirmed = true;
            user.PhoneNumberConfirmed = true;

            var doctor = _mapper.Map<Doctor>(dto);
            doctor.User = user;

            var clinica = _context.Clinicas.FirstOrDefault(x => x.Id == dto.ClinicaId);
            var speciality = _context.Specialities.FirstOrDefault(x => x.Id == dto.SpecialityId);
            doctor.Clinica = clinica ?? throw new ArgumentException(AdminErrorMessages.ClinicaNotFound);
            doctor.Speciality = speciality ?? throw new ArgumentException(AdminErrorMessages.SpecialityNotFound);

            var resultAddingUser = await _userManager.CreateAsync(user, dto.Password);
            if (!resultAddingUser.Succeeded)
            {
                StringBuilder errorMessage = new();
                foreach (var exception in resultAddingUser.Errors)
                {
                    errorMessage.AppendLine(exception.Description + ";");
                }

                throw new ArgumentException(errorMessage.ToString());
            }

            var identityUser = await _userManager.FindByEmailAsync(user.Email);
            await _userManager.AddToRoleAsync(identityUser, "Doctor");

            await _context.AddAsync(doctor);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateDoctor(UpdateDoctorDTO dto)
        {
            var currentDoctor = _context.Doctors.Include(d => d.User).FirstOrDefault(x => x.Id == dto.Id);
            var currentUser = _context.Users.FirstOrDefault(u => u.Id == currentDoctor.User.Id);

            var clinica = _context.Clinicas.FirstOrDefault(x => x.Id == dto.ClinicaId);
            if (clinica == null) throw new ArgumentException(AdminErrorMessages.ClinicaNotFound);
            var speciality = _context.Specialities.FirstOrDefault(x => x.Id == dto.SpecialityId);
            if(speciality == null) throw new ArgumentException(AdminErrorMessages.SpecialityNotFound);

            currentDoctor.Clinica = clinica;
            currentDoctor.FirstName = dto.FirstName;
            currentDoctor.LastName = dto.LastName;
            currentDoctor.Speciality = speciality;
            currentDoctor.Rate = dto.Rate;

            currentUser.UserName = dto.Email;
            currentUser.Email = dto.Email;
            currentUser.PhoneNumber = dto.Phone;
            await _context.SaveChangesAsync();
        }

        public async Task<UpdateDoctorDTO> GetDoctor(Guid id)
        {
            var doctor = await _context.Doctors.Include(d => d.Clinica).Include(d => d.Speciality).Include(d => d.User).FirstOrDefaultAsync(x => x.Id == id);

            if (doctor == null) throw new ArgumentException(AdminErrorMessages.DoctorNotFound);

            var doctorData = new UpdateDoctorDTO()
            {
                Id = id,
                ClinicaId = doctor.Clinica.Id,
                FirstName = doctor.FirstName,
                Email = doctor.User.Email,
                LastName = doctor.LastName,
                Phone = doctor.User.PhoneNumber,
                Rate = doctor.Rate,
                SpecialityId = doctor.Speciality.Id
            };
            return doctorData;
        }

        public async Task DeleteDoctor(Guid id)
        {
            var doctor = _context.Doctors.Include(d => d.User).FirstOrDefault(x => x.Id == id);
            var user = doctor.User;
            if (doctor == null) throw new ArgumentException(AdminErrorMessages.DoctorNotFound);

            _context.Remove(doctor);
            await _context.SaveChangesAsync();
            _context.Remove(user);
            await _context.SaveChangesAsync();
        }
    }
}
