using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("doctors")]
        public async Task<IActionResult> GetDoctors()
        {
            var result = _userService.GetDoctors();
            return Ok(result);
        }

        [HttpGet("doctorspecialities")]
        public async Task<IActionResult> GetDoctorSpecialities()
        {
            var result = _userService.GetDoctorSpecialties();
            return Ok(result);
        }

        [HttpGet("clinicaspecialities")]
        public async Task<IActionResult> GetClinicaSpecialities()
        {
            var result = _userService.GetClinicaSpecialties();
            return Ok(result);
        }

        [HttpGet("clinicas")]
        public async Task<IActionResult> GetClinicas()
        {
            var result = _userService.GetClinicas();
            return Ok(result);
        }

        [HttpGet("doctorfeedbacks/{id}")]
        public async Task<IActionResult> GetDoctorFeedbacks(string id)
        {
            var doctorId = Guid.Parse(id);
            var result = await _userService.GetFeedbacksDoctor(doctorId);
            return Ok(result);
        }

        [HttpGet("userid")]
        [Authorize]
        public async Task<IActionResult> GetId()
        {
            var id = await _userService.GetUserId(User.Identity.Name);
            return Ok(id);
        }

        [HttpGet("patientid")]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> GetPatientId()
        {
            var id = await _userService.GetPatientId(User.Identity.Name);
            return Ok(id);
        }
    }
}
