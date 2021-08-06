using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Constants
{
    public class AppointmentErrorMessages
    {
        public const string PatientNotFound = "Patient not found. Ensure patient id";
        public const string DoctorNotFound = "Doctor not found. Ensure doctor id";
        public const string ClinicaNotFound = "Clinica not found. Ensure clinica id";
        public const string AppointmentNotFound = "No one such an appointment";
    }
}
