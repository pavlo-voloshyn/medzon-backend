using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTOs
{
    public class DoctorToFrontDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Rate { get; set; }
        public string Clinica { get; set; }
        public string Speciality { get; set; }
    }
}
