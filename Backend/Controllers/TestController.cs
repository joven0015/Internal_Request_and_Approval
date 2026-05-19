using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/test")]
    public class TestController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TestController(AppDbContext context)
        {
            _context = context;
        }

       

        [HttpGet]
        public IActionResult Test()
        {
            try
            {
                var canConnect = _context.Database.CanConnect();

                return Ok(new
                {
                    Connected = canConnect
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
