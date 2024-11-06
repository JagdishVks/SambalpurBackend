using dharmendraPradhan.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dharmendraPradhan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusGetAllLocsController : ControllerBase
    {
        private readonly StatusGetAllLocsContext _context;

        public StatusGetAllLocsController(StatusGetAllLocsContext context)
        {
            _context = context;
        }

        [HttpGet("{Statename}")]
        public async Task<IActionResult> GetAllLocs(String Statename)
        {
            var result = await _context.StatusGetAllLocs
                        .Where(l.State_Name=>Statename)
                        .Select(l => new
                        {
                            l.AC_Name,
                            l.Village_Name,
                            l.Loc_ID
                        })
                        .ToListAsync();

            if (result == null || !result.Any())
            {
                return NotFound(new { message = "No records found for the given Loc_ID" });
            }

            return Ok(result);
        }

        [HttpGet("{Loc_ID}")]
        public async Task<IActionResult> GetAllLocsById(string Loc_ID)
        {
            var result = await _context.StatusGetAllLocs
                         .Where(l=>l.Loc_ID==Loc_ID)
                        .Select(l => new
                        {
                            l.AC_Name,
                            l.Village_Name,
                            
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
