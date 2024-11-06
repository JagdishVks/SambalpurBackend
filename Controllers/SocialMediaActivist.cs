using dharmendraPradhan.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace dharmendraPradhan.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaActivistController : ControllerBase
    {
        private readonly StatusSocialMediaActContext _context;

        public SocialMediaActivistController(StatusSocialMediaActContext context)
        {
            _context = context;
        }

        [HttpGet("{Loc_ID}")]
        public async Task<IActionResult> GetSocialMediaActivist(string Loc_ID)
        {

            var result = await _context.SocialMediaActivist.Where(l => l.Loc_ID == Loc_ID)

                    .Select(l => new { l.Gender, l.Age, l.Community, l.Mobile, l.Worker_Name }).ToListAsync();

            if (result.Count() != 0)
            { return Ok(result); }

            return NotFound();
        }

    }
}
