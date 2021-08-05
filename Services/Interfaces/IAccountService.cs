using Services.DTOs;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IAccountService
    {
        Task LogUp(FreshUserDTO dto);
        Task<string> LogIn(UserPassDTO dto);
    }
}
