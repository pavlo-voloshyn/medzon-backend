using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.ViewModels
{
    public class ClinicaFeedbackView
    {
        public string PatientId { get; set; }
        public string ClinicaId { get; set; }
        public string Content { get; set; }
        public int Stars { get; set; }
    }
}
