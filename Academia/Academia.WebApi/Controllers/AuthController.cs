using Academia.Dtos;
using Academia.Services;
using Academia.WebApi.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Academia.WebApi.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [TypeFilter(typeof(ExceptionManager))]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

       
        [HttpPost("login")]
        public async Task<ActionResult<LoginResponse>> Login(LoginRequest loginRequest)
        {
            try
            {
                var response = await _authService.Login(loginRequest);
                if (response == null)
                    return Unauthorized();
                return Ok(response);
            }
            catch (Exception e)
            {
                return Problem($"error en el login: {e.Message}");
            }
        }
    }
}