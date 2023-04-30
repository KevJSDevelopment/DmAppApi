using AutoMapper;
using DMApp.Dtos;
using DMApp.Models;

namespace DMApp.Profiles
{
    public class CharacterProfile : Profile
    {

        public CharacterProfile()
        { 
            CreateMap<Character, CharacterReadDto>();
        }
    }
}
