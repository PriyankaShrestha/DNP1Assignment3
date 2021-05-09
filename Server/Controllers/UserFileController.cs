using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using Server.Data.UserService;

namespace Server.Controllers
{
    [ApiController]
    [Route("/users")]
    public class UserFileController : ControllerBase
    {
        private IUserService userService;

        public UserFileController(IUserService service)
        {
            userService = service;
        }
        
        [HttpGet]
        public async Task<ActionResult<User>> ValidateUser([FromQuery] string username, [FromQuery] string password)
        {
            try
            {
                User user = await userService.ValidateUserAsync(username, password);
                return Ok(user);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        
        [HttpPost]
        public async Task<ActionResult<User>> AddUser([FromBody] User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                User toAdd = await userService.AddUserAsync(user);
                return Created($"/{toAdd}", toAdd);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}