using Services.DTOs;
using System;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IAdminService
    {
        Task AddDoctor(FreshDoctorDTO dto);
        Task DeleteDoctor(Guid id);
        Task UpdateDoctor(UpdateDoctorDTO dto);
        Task<UpdateDoctorDTO> GetDoctor(Guid id);
    }
}
