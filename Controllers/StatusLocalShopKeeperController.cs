using dharmendraPradhan.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace dharmendraPradhan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusLocalShopKeeperController : ControllerBase
    {
        private readonly StatusLocalShopKeeperContext _context;

        public StatusLocalShopKeeperController(StatusLocalShopKeeperContext context)
        {
            _context = context;
        }

        [HttpGet("{Loc_ID}")]
        public async Task<IActionResult> GetLocalShopKeeper(string Loc_ID)
        {
            var result = await _context.StatusLocalShopKeepers
                        .Where(l => l.Loc_ID == Loc_ID)
                        .Select(l => new
                        {
                            l.Person_Name,
                            l.Community,
                            l.Mobile
                        })
                        .ToListAsync();

            if (result == null || !result.Any())
            {
                return NotFound(new { message = "No records found for the given Loc_ID" });
            }

            return Ok(result);
        }
    }
}
