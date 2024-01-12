using Microsoft.AspNetCore.Mvc;
using store.Service;
using store.Service.Models;
using store.Service.UsersService;
using Swashbuckle.AspNetCore.Annotations;

namespace store.API.Controllers
{
    [Route("api/[controller]")]

    public class UsersController : Controller
    {
        private readonly IUserService _userService;
        private readonly IAuthService _authService;

        public UsersController(IUserService userService, IAuthService authService)
        {
            _userService = userService;
            _authService = authService;
        }

        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(List<UsersServiceDB>))]
        [SwaggerResponse(StatusCodes.Status404NotFound)]
        [HttpGet(Name = "Users")]
        public async Task<ActionResult<List<UsersServiceDB>>> getUsers()
        {
            var users = await _userService.GetAllUsers();
            if (users is null)
            {
                return NotFound();
            }
            return Ok(users);
        }
        [SwaggerResponse(StatusCodes.Status201Created)]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        [HttpPost(Name = "Login")]
        public async Task<IActionResult> Login([FromBody] UsersServiceDB request)
        {
            if (request == null)
            {
                return BadRequest("Invalid request");
            }

            
            bool isAuthenticated = await _authService.AuthenticateUser(request.UserName, request.Password);

            if (isAuthenticated)
            {
                return Created(new Uri("http://localhost"), "Login successful.");
            }
            else
            {
                return Unauthorized("Login failed.");
            }

        }

    }
}
