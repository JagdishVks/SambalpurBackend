using dharmendraPradhan.Models;
using Microsoft.EntityFrameworkCore;

namespace dharmendraPradhan.Data
{
    public class StatusLocalShopKeeperContext : DbContext
    {
        public StatusLocalShopKeeperContext(DbContextOptions<StatusLocalShopKeeperContext> options) : base(options)
        {
        }

        public DbSet<StatusLocalShopKeeperModel> StatusLocalShopKeepers { get; set; }
    }
}
