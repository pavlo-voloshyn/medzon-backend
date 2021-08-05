using AutoMapper;
using Domain.Entities;
using Domain.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Services.Constants;
using Services.DTOs;
using Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace Services
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly MDContext _context;
        private readonly IMapper _mapper;

        public AccountService(UserManager<IdentityUser> userManager, MDContext context, IMapper mapper)
        {
            _userManager = userManager;
            _context = context;
            _mapper = mapper;
        }

        public async Task LogUp(FreshUserDTO dto)
        {
            var user = _mapper.Map<IdentityUser>(dto);
            user.EmailConfirmed = true;
            user.PhoneNumberConfirmed = true;

            var patient = _mapper.Map<Patient>(dto);
            patient.User = user;

            var resultAddingUser = await _userManager.CreateAsync(user, dto.Password);
            if (!resultAddingUser.Succeeded) throw new Exception(AccountErrorMessages.FailedCreate);

            var identityUser = await _userManager.FindByEmailAsync(user.Email);
            await _userManager.AddToRoleAsync(identityUser, "User");

            await _context.AddAsync(patient);
            await _context.SaveChangesAsync();
        }
    }
}
