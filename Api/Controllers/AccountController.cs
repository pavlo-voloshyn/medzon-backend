using Api.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.DTOs;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public AccountController(IAccountService accountService, IMapper mapper)
        {
            _accountService = accountService;
            _mapper = mapper;
        }

        [HttpPost("logup")]
        [AllowAnonymous]
        public async Task<IActionResult> LogUp(FreshUserView freshUser)
        {
            var userDTO = _mapper.Map<FreshUserDTO>(freshUser);
            await _accountService.LogUp(userDTO);
            return Ok();
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> LogIn(UserPassView userPass)
        {
            var userPassDTO = _mapper.Map<UserPassDTO>(userPass);
            var token = await _accountService.LogIn(userPassDTO);
            return Ok(token);
        }
    }
}
