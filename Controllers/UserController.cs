using AutoMapper;
using DMApp.Data;
using DMApp.Dtos;
using DMApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using DMApp.HelperClasses;

namespace DMApp.Controllers
{
    public class UserController : ControllerBase
    {
        private readonly IUserRepo _repository;
        private readonly IMapper _mapper;

        public UserController(IUserRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpPost("/login")]
        public ActionResult<User> Login(UserLoginDto userLoginDto)
        {
            var user = _repository.GetUserByUsername(userLoginDto.Username);
            if (user != null && user.Password == userLoginDto.Password)
            {
                return Ok(_mapper.Map<UserReadDto>(user));
            }

            RequestResponse response = new RequestResponse();
            response.Status = 400;
            response.Message = "Username or password is incorrect";

            return BadRequest(error: JsonConvert.SerializeObject(response));
        }

        [HttpPost("/SignIn")]
        public ActionResult<UserReadDto> CreateUser([FromBody] UserCreateDto userCreateDto)
        {
            User userModel = _mapper.Map<User>(userCreateDto);

            _repository.CreateUser(userModel);
            _repository.SaveChanges();

            UserReadDto userReadDto = _mapper.Map<UserReadDto>(userModel);

            return Ok(userReadDto);
        }
    }
}
