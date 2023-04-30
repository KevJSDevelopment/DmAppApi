using AutoMapper;
using DMApp.Dtos;
using DMApp.Models;

namespace DMApp.Profiles
{
    public class UsersProfile : Profile
    {

        public UsersProfile() 
        { 
            CreateMap<User, UserReadDto>();
            CreateMap<User, UserCreateDto>();
            CreateMap<User, UserUpdateDto>();
            CreateMap<UserUpdateDto, User>();
            CreateMap<UserCreateDto, User>();
            CreateMap<UserLoginDto, UserReadDto>();
        }
    }
}
