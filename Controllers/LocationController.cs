using dharmendraPradhan.Data;
using dharmendraPradhan.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dharmendraPradhan.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class LocationController : ControllerBase
    {
        private readonly LocationContext _context;

        public LocationController(LocationContext context)
        {
            _context = context;
        }

        [HttpGet("{loc_name}")]
        public async Task<IActionResult> GetLocationInfo(string loc_name)
        {
            // 1. Check if the parameter matches State_Name
            var stateResult = await _context.Locations
                .Where(l => l.State_Name == loc_name)
                .Select(l => new
                {
                    l.Latitude,
                    l.Longitude,
                    l.PC_Name,
                    l.Village_Name,
                    l.AC_Name
                })
                .ToListAsync();

            if (stateResult.Any())
            {
                return Ok(stateResult); // Return latitude, longitude, PC_Name, VillageName, AC_Name for matching State_Name
            }

            // 2. Check if the parameter matches PC_Name
            var pcResult = await _context.Locations
                .Where(l => l.PC_Name == loc_name)
                .Select(l => new
                { 
                    l.AC_Name,
                    l.Village_Name,
                    l.Latitude,
                    l.Longitude
                })
                .ToListAsync();

            if (pcResult.Any())
            {
                return Ok(pcResult); // Return AC_Name, VillageName, Latitude, Longitude for matching PC_Name
            }

            // 3. Check if the parameter matches AC_Name
            var acResult = await _context.Locations
                .Where(l => l.AC_Name == loc_name)
                .Select(l => new
                {
                    l.Village_Name,
                    l.Latitude,
                    l.Longitude
                })
                .ToListAsync();

            if (acResult.Any())
            {
                return Ok(acResult); // Return VillageName, Latitude, Longitude for matching AC_Name
            }

            // 4. Check if the parameter matches VillageName
            var villageResult = await _context.Locations
                .Where(l => l.Village_Name == loc_name)
                .Select(l => new
                {
                    l.Latitude,
                    l.Longitude
                })
                .ToListAsync();

            if (villageResult.Any())
            {
                return Ok(villageResult); // Return Latitude, Longitude for matching VillageName
            }

            // 5. If no match, return 404 Not Found
            return NotFound($"No location information found for: {loc_name}");
        }
    }
}
