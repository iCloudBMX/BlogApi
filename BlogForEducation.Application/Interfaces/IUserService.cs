using BlogForEducation.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogForEducation.Application.Interfaces
{
    public interface IUserService
    {
        Task<IReadOnlyList<UserDto>> GetAllUsersAsync();

        Task<UserDto> GetUserByIdAysnc(int id);

        Task<UserDto> CreateUserAsync(UserForCreationDto user);
    }
}
