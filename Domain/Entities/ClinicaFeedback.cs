using Domain.Entities.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ClinicaFeedback : EntityBase
    {
        public Patient Patient { get; set; }

        public DateTime Date { get; set; }

        public string Content { get; set; }

        public int Stars { get; set; }
        public Clinica Clinica { get; set; }
        public Guid ClinicaId { get; set; }
    }
}
