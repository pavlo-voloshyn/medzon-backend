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
    public class PatientController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;
        private readonly IMapper _mapper;

        public PatientController(IAppointmentService appointmentService, IMapper mapper)
        {
            _appointmentService = appointmentService;
            _mapper = mapper;
        }

        [HttpPost("appointment")]
        public async Task<IActionResult> SetAppointment(AppointmentView view)
        {
            var dto = _mapper.Map<AppointmentDTO>(view);
            await _appointmentService.SetAppointment(dto);
            return Ok();
        }

        [HttpDelete("appointment/{id}")]
        public async Task<IActionResult> DeleteAppointment(string id)
        {
            var guidId = Guid.Parse(id);
            await _appointmentService.DeleteAppointment(guidId);
            return Ok();
        }

        [HttpGet("appointment/{id}")]
        public async Task<IActionResult> GetAppointments(string id)
        {
            var guidId = Guid.Parse(id);
            var result = _appointmentService.GetPatientAppointments(guidId);
            return Ok(result);
        }
    }
}
