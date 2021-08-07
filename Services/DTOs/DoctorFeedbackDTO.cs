using System;

namespace Services.DTOs
{
    public class DoctorFeedbackDTO
    {
        public Guid PatientId { get; set; }
        public Guid DoctorId { get; set; }
        public string Content { get; set; }
        public int Stars { get; set; }
    }
}
