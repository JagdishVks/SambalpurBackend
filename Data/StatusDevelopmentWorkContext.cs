using dharmendraPradhan.Models;
using Microsoft.EntityFrameworkCore;

namespace dharmendraPradhan.Data
{
    public class StatusDevelopmentWorkContext : DbContext
    {
        public StatusDevelopmentWorkContext(DbContextOptions<StatusDevelopmentWorkContext> options) : base(options)
        {
        }

        public DbSet<StatusDevelopmentWorkModel> StatusDevelopmentWork { get; set; }
    }
}
