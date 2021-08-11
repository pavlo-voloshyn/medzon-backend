using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTOs
{
    public class FeedbackToFrontDTO
    {
        public string PatientId { get; set; }
        public string Date { get; set; }
        public string Content { get; set; }
        public int Stars { get; set; }
        public string DoctorId { get; set; }
    }
}
