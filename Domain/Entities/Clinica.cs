using Domain.Entities.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Clinica : EntityBase
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        
        [Required]
        [MaxLength(200)]
        public string Address { get; set; }

        [Required]
        [Range(0, 5)]
        public double Rate { get; set; }
        
        public SpecialityClinica Speciality { get; set; }
        public List<Feedback> Feedbacks { get; set; }
        public List<Doctor> Doctors { get; set; }
    }
}
