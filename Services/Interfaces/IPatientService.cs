using Services.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IPatientService
    {
        Task AddFavotireDoctor(FavoriteDoctorDTO dto);
        Task RemoveFavotireDoctor(FavoriteDoctorDTO dto);
        Task<List<string>> SeeFavoriteDoctors(Guid id);
    }
}
