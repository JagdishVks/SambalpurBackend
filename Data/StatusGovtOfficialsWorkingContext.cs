using dharmendraPradhan.Models;
using Microsoft.EntityFrameworkCore;

namespace dharmendraPradhan.Data
{
    public class StatusGovtOfficialsWorkingContext : DbContext
    {
        public StatusGovtOfficialsWorkingContext(DbContextOptions<StatusGovtOfficialsWorkingContext> options) : base(options)
        {
        }

        public DbSet<StatusGovtOfficialsWorkingModel> StatusGovtOfficialsWorking { get; set; }
    }
}
