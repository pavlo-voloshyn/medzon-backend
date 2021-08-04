using Domain.Entities.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Appointment : EntityBase
    {
        [Required]
        public DateTime Date { get; set; }
        
        [Required]
        public Patient Patient { get; set; }
        
        [Required]
        public Doctor Doctor { get; set; }
        public Clinica Clinica { get; set; }
    }
}
