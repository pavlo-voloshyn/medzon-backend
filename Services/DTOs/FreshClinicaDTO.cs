using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTOs
{
    public class FreshClinicaDTO
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public double Rate { get; set; }
        public Guid SpecialityId { get; set; }
    }
}
