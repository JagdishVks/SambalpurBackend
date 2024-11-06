using dharmendraPradhan.Data;
using dharmendraPradhan.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dharmendraPradhan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetLocIDAndBoothController : ControllerBase
    {
        private readonly GetLocIDAndBoothContext _context;

        public GetLocIDAndBoothController(GetLocIDAndBoothContext context)
        {
            _context = context;
        }

        [HttpGet("{acName}/{villageName}")]
        public async Task<IActionResult> GetLocIDAndBooth(string acName, string villageName)
        {
            var result = await _context.GetLocIDAndBooth
                .Where(l => l.AC_Name == acName && l.Village_Name == villageName)
                .Select(l => new { l.Loc_ID, l.Booth_no })
                .ToListAsync();

            if (result.Count == 0)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}
