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
        private readonly IPatientService _patientService;
        private readonly IMapper _mapper;

        public PatientController(IAppointmentService appointmentService, IPatientService patientService, IMapper mapper)
        {
            _appointmentService = appointmentService;
            _patientService = patientService;
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

        [HttpPost("favoritedoctor")]
        public async Task<IActionResult> AddFavoriteDoctor(FavoriteDoctorView view)
        {
            var dto = _mapper.Map<FavoriteDoctorDTO>(view);
            await _patientService.AddFavotireDoctor(dto);
            return Ok();
        }

        [HttpDelete("favoritedoctor")]
        public async Task<IActionResult> RemoveFavoriteDoctor(FavoriteDoctorView view)
        {
            var dto = _mapper.Map<FavoriteDoctorDTO>(view);
            await _patientService.RemoveFavotireDoctor(dto);
            return Ok();
        }

        [HttpGet("favoritedoctors")]
        public async Task<IActionResult> GetFavoriteDoctors(string id)
        {
            var patientId = Guid.Parse(id);
            var result = await _patientService.SeeFavoriteDoctors(patientId);
            return Ok(result);
        }

        [HttpPost("doctorfeedback")]
        public async Task<IActionResult> AddDoctorFeedback(DoctorFeedbackView view)
        {
            var dto = _mapper.Map<DoctorFeedbackDTO>(view);
            await _patientService.AddFeedbackToDoctor(dto);
            return Ok();
        }

        [HttpDelete("doctorfeedback/{id}")]
        public async Task<IActionResult> DeleteDoctorFeedback(string id)
        {
            var feedbackId = Guid.Parse(id);
            await _patientService.DeleteFeedbackToDoctor(feedbackId);
            return Ok();
        }

        [HttpPost("clinicafeedback")]
        public async Task<IActionResult> AddClinicaFeedback(ClinicaFeedbackView view)
        {
            var dto = _mapper.Map<ClinicaFeedbackDTO>(view);
            await _patientService.AddFeedbackToClinica(dto);
            return Ok();
        }

        [HttpDelete("clinicafeedback/{id}")]
        public async Task<IActionResult> DeleteClinicaFeedback(string id)
        {
            var feedbackId = Guid.Parse(id);
            await _patientService.DeleteFeedbackToClinica(feedbackId);
            return Ok();
        }

    }
}
