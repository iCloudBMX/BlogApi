using AutoMapper;
using BlogForEducation.Application.DTOs;
using BlogForEducation.Domain.Models;

namespace BlogForEducation.Application.Profiles
{
    public class MappingInitializer : Profile
    {
        public MappingInitializer()
        {

            // UserDto -> User
            // User -> UserDto
            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<UserForCreationDto, User>().ReverseMap();
        }
    }
}
