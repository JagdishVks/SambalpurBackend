using dharmendraPradhan.Models;
using Microsoft.EntityFrameworkCore;

namespace dharmendraPradhan.Data
{
    public class StatusAreaDevelopContext : DbContext
    {
        public StatusAreaDevelopContext(DbContextOptions<StatusAreaDevelopContext> options) : base(options)
        {
        }

        public DbSet<StatusAreaDevelopModel> StatusAreaDevelops { get; set; }
        //public IEnumerable<object> StatusAreaDevelop { get; internal set; }
    }
}
