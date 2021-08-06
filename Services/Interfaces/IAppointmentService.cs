using Domain.Entities;
using Services.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IAppointmentService
    {
        Task SetAppointment(AppointmentDTO dto);
        Task DeleteAppointment(Guid id);
        Task UpdateTimeAppointment(UpdateAppointmentDTO dto);
        List<AppointmentToFrontDTO> GetDoctorAppointments(Guid doctorId);
        List<AppointmentToFrontDTO> GetPatientAppointments(Guid patientId);
    }
}
