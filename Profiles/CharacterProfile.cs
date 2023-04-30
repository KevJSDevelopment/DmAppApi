using AutoMapper;
using DMApp.Dtos;
using DMApp.Models;
using DmAppAPI.Dtos;

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
