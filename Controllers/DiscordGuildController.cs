using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using DMApp.Dtos;
using DMApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace DMApp.Data
{
    public class DiscordGuildController : Controller
    {
        private readonly IDiscordGuildRepo _repository;
        private readonly IMapper _mapper;

        public DiscordGuildController(IDiscordGuildRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpPost("/characters/new/{guildId}")]
        public ActionResult AddGuild([FromQuery] long guildId = 1077311704985239684)
        {
            DiscordGuild guild = _repository.CreateGuild(guildId);
            if (_repository.SaveChanges()) return Ok(guild);
            else return BadRequest(new { error = "Unable to save character" });
        }
    }
}