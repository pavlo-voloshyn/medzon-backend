using Domain.Entities.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Feedback : EntityBase
    {
        public Patient Patient { get; set; }

        public DateTime Date { get; set; }

        public string Content { get; set; }

        [Range(0,5)]
        public int Stars { get; set; }

        public Doctor Doctor { get; set; }
        public Guid DoctorId { get; set; }
        public Clinica Clinica { get; set; }
        public Guid ClinicaId { get; set; }
    }
}
