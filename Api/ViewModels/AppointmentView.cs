using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.ViewModels
{
    public class AppointmentView
    {
        [Required]
        [DataType(DataType.Date)]
        public string Date { get; set; }

        [Required]
        public string PatientId { get; set; }

        [Required]
        public string DoctorId { get; set; }
        
        [Required]
        public string ClinicaId { get; set; }
    }
}
