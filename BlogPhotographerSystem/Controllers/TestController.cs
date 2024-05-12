using BlogPhotographerSystem_Core.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogPhotographerSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly BlogPhotographerSystemDBContext _context;


        
        public TestController(BlogPhotographerSystemDBContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllUsers()
        {
            var ss = from user in _context.Users
                     select user;
            return Ok(await ss.ToListAsync());

        }

    }
}
