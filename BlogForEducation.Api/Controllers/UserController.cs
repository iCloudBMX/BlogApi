using BlogForEducation.Application.DTOs;
using BlogForEducation.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BlogForEducation.Api.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            return Ok(await _userService.GetAllUsersAsync());
        }

        [HttpGet("id:int")]
        public async Task<IActionResult> GetUserById(int id)
        {
            return Ok(await _userService.GetUserByIdAysnc(id));
        }

        [HttpPost()]
        public async Task<IActionResult> GetUserById([FromBody] UserForCreationDto userDto)
        {
            return Created("", await _userService.CreateUserAsync(userDto));
        }
    }
}
