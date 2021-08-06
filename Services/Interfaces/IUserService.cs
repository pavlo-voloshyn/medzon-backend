using Services.DTOs;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IUserService
    {
        List<DoctorToFrontDTO> GetDoctors();
    }
}
