using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.ViewModels
{
    public class UpdateClinicaView
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Rate { get; set; }
        public string SpecialityId { get; set; }
    }
}
