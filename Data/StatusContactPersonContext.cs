using dharmendraPradhan.Models;
using Microsoft.EntityFrameworkCore;

namespace dharmendraPradhan.Data
{
    public class StatusContactPersonContext : DbContext
    {
        public StatusContactPersonContext(DbContextOptions<StatusContactPersonContext> options) : base(options)
        {
        }

        public DbSet<StatusContactPersonModel> StatusContactPerson { get; set; }
    }
}
