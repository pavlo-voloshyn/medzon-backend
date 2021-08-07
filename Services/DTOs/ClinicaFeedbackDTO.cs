using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTOs
{
    public class ClinicaFeedbackDTO
    {
        public Guid PatientId { get; set; }
        public Guid ClinicaId { get; set; }
        public string Content { get; set; }
        public int Stars { get; set; }
    }
}
