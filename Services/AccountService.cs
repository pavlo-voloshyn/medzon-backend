using AutoMapper;
using Domain.Entities;
using Domain.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Services.Constants;
using Services.DTOs;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
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
            if (!resultAddingUser.Succeeded)
            {
                StringBuilder errorMessage = new StringBuilder();
                foreach(var exception in resultAddingUser.Errors)
                {
                    errorMessage.AppendLine(exception.Description + ";");
                }

                throw new ArgumentException(errorMessage.ToString());
            } 

            var identityUser = await _userManager.FindByEmailAsync(user.Email);
            await _userManager.AddToRoleAsync(identityUser, "User");

            await _context.AddAsync(patient);
            await _context.SaveChangesAsync();
        }

        public async Task<string> LogIn(UserPassDTO dto)
        {
            var identity = await GetIdentity(dto.Email, dto.Password);
            if (identity == null) throw new ArgumentException(AccountErrorMessages.InvalidUserData);

            var now = DateTime.UtcNow;
            var jwt = new JwtSecurityToken(
                    issuer: AuthOptions.ISSUER,
                    audience: AuthOptions.AUDIENCE,
                    notBefore: now,
                    claims: identity.Claims,
                    expires: now.Add(TimeSpan.FromDays(AuthOptions.LIFETIME)),
                    signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

            var response = new
            {
                access_token = encodedJwt,
                username = identity.Name
            };

            return JsonSerializer.Serialize(response);
        }

        private async Task<ClaimsIdentity> GetIdentity(string username, string password)
        {
            var user = await _userManager.FindByEmailAsync(username);
            if (user == null) throw new ArgumentException(AccountErrorMessages.UserNotFound);

            var passwordCorrect = await _userManager.CheckPasswordAsync(user, password);
            if (!passwordCorrect) throw new ArgumentException(AccountErrorMessages.IncorrectPassword);

            var userRole = _userManager.GetRolesAsync(user).Result[0];

            var claims = new List<Claim>
                {
                    new Claim(ClaimsIdentity.DefaultNameClaimType, user.Email),
                    new Claim(ClaimsIdentity.DefaultRoleClaimType, userRole)
                };
            ClaimsIdentity claimsIdentity =
            new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);
            return claimsIdentity;
        }
    }
}
