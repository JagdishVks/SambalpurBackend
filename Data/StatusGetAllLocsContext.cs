using dharmendraPradhan.Models;
using Microsoft.EntityFrameworkCore;

namespace dharmendraPradhan.Data
{
    public class StatusGetAllLocsContext : DbContext
    {
        public StatusGetAllLocsContext(DbContextOptions<StatusGetAllLocsContext> options) : base(options)
        {
        }

        public DbSet<StatusGetAllLocsModel> StatusGetAllLocs { get; set; }
    }
}
