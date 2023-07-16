﻿using AutoMapper;
using DMApp.Data;
using DMApp.Dtos.CharacterSheetPropertyDto;
using DMApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DMApp.Controllers
{
    public class CharacterRaceConroller : Controller
	{
        private readonly IRaceRepo _raceRepo;
        private readonly IDiscordGuildRepo _guildRepo;
        private readonly IMapper _mapper;

        public CharacterRaceConroller(IRaceRepo raceRepo, IDiscordGuildRepo guildRepo, IMapper mapper)
        {
            _raceRepo = raceRepo;
            _guildRepo = guildRepo;
            _mapper = mapper;
        }

        [HttpPost("/character-race/{guildId}")]
        public ActionResult CreateCharacterRace([FromBody] CharacterSheetPropertyDto characterRaceDto, long guildId)
        {
            CharacterRace characterRace = _mapper.Map<CharacterRace>(characterRaceDto);
            DiscordGuild guild = _guildRepo.GetGuildByGuildId(guildId);

            if (guild == null)
            {
                guild = _guildRepo.CreateGuild(guildId);
            }

            characterRace.Guilds.Add(guild);

            _raceRepo.CreateCharacterRace(characterRace, guildId);

            return Ok(new { Status = 200, message = "Race Created" });
        }
    }
}

