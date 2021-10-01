using Domain.Entities.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Patient : UserBase
    {
        public DateTime Birthday { get; set; }
        public List<Doctor> Doctors { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}
