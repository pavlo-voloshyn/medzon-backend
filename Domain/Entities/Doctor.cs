using Domain.Entities.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Doctor : UserBase
    {
        [Required]
        [Range(0,5)]
        public double Rate { get; set; }

        [Required]
        public Clinica Clinica { get; set; }

        [Required]
        public Speciality Speciality { get; set; }
        public List<Feedback> Feedbacks { get; set; }
        public List<Patient> Patients { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}
