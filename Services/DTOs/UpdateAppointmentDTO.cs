using System;

namespace Services.DTOs
{
    public class UpdateAppointmentDTO
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
    }
}
