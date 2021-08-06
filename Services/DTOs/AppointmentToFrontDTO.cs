using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTOs
{
    public class AppointmentToFrontDTO
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public string Patient { get; set; }
        public string Doctor { get; set; }
        public string Clinica { get; set; }
    }
}
