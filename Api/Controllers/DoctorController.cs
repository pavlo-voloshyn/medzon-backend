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
    [Authorize(Roles = "Doctor")]
    public class DoctorController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;
        private readonly IMapper _mapper;

        public DoctorController(IAppointmentService appointmentService, IMapper mapper)
        {
            _appointmentService = appointmentService;
            _mapper = mapper;
        }

        [HttpPut("appointment")]
        public async Task<IActionResult> UpdateAppointment(UpdateAppointmentView view)
        {
            var dto = _mapper.Map<UpdateAppointmentDTO>(view);
            await _appointmentService.UpdateTimeAppointment(dto);
            return Ok();
        }

        [HttpGet("appointment/{id}")]
        public async Task<IActionResult> GetAppointments(string id)
        {
            var guidId = Guid.Parse(id);
            var result = _appointmentService.GetDoctorAppointments(guidId);
            return Ok(result);
        }

    }
}
