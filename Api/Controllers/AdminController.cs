using Api.ViewModels;
using AutoMapper;
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
    
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;
        private readonly IMapper _mapper;

        public AdminController(IAdminService adminService, IMapper mapper)
        {
            _adminService = adminService;
            _mapper = mapper;
        }

        [HttpPost("doctor")]
        public async Task<IActionResult> CreateDoctor(FreshDoctorView view)
        {
            var dto = _mapper.Map<FreshDoctorDTO>(view);
            await _adminService.AddDoctor(dto);
            return Ok();
        }

        [HttpDelete("doctor/{id}")]
        public async Task<IActionResult> DeleteDoctor(string id)
        {
            var doctorId = Guid.Parse(id);
            await _adminService.DeleteDoctor(doctorId);
            return Ok();
        }

        [HttpPut("doctor")]
        public async Task<IActionResult> UpdateDoctor(UpdateDoctorView view)
        {
            var dto = _mapper.Map<UpdateDoctorDTO>(view);
            await _adminService.UpdateDoctor(dto);
            return Ok();
        }

        [HttpGet("doctor/{id}")]
        public async Task<IActionResult> GetDoctor(string id)
        {
            var doctorId = Guid.Parse(id);
            var result = await _adminService.GetDoctor(doctorId);
            return Ok(result);
        }
    }
}
