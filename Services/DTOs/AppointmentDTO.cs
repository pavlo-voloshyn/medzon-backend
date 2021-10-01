using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTOs
{
    public class AppointmentDTO
    {
        public DateTime Date { get; set; }
        public Guid PatientId { get; set; }
        public Guid DoctorId { get; set; }
        public Guid ClinicaId { get; set; }
    }
}
