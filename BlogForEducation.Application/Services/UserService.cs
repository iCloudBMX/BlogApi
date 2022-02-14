using AutoMapper;
using BlogForEducation.Application.DTOs;
using BlogForEducation.Application.Interfaces;
using BlogForEducation.Domain.Models;
using BlogForEducation.Infrastructure.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogForEducation.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepositoryAsync _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepositoryAsync userRepository, IMapper mapper)
        {
            _userRepository = userRepository;

            _mapper = mapper;
        }

        public async Task<UserDto> CreateUserAsync(UserForCreationDto userDto)
        {
            var user = _mapper.Map<User>(userDto);

            return _mapper.Map<UserDto>(await _userRepository.AddAsync(user));
        }

        public async Task<IReadOnlyList<UserDto>> GetAllUsersAsync()
        {
            return _mapper.Map<IReadOnlyList<UserDto>>(await _userRepository.GetAllAsync());
        }

        public async Task<UserDto> GetUserByIdAysnc(int id)
        {
            return _mapper.Map<UserDto>(await _userRepository.GetByIdAsync(id));
        }
    }
}
