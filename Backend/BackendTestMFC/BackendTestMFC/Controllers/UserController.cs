using BackendTestMFC.Data;
using BackendTestMFC.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BackendTestMFC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly DataContext _context;
        public UserController(DataContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public async Task<IActionResult> AuthUser(RequestAuth user)
        {
            var response = new Response();
            var result = _context.ms_user.Where(a => a.user_name == user.username).FirstOrDefault();
            if (result == null) {
                response.message = "Username atau password salah";
                return BadRequest(response);
            }
            else
            {
                if (result.password != user.password) {
                    response.code = 400;
                    response.message = "Username atau password salah";  
                    return BadRequest(response); 
                }
                if (!result.is_active)
                {
                    response.code = 400;
                    response.message = "User tidak aktif";
                    return BadRequest(response);
                }

                return Ok(result);
            }
        }
    }
}
