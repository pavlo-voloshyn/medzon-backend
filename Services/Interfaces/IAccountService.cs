using Services.DTOs;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IAccountService
    {
        Task LogUp(FreshUserDTO dto);
    }
}
