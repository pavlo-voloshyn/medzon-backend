﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.ViewModels
{
    public class UpdateDoctorView
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public double Rate { get; set; }
        public string ClinicaId { get; set; }
        public string SpecialityId { get; set; }
    }
}
