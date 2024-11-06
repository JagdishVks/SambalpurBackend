using dharmendraPradhan.Models;
using Microsoft.EntityFrameworkCore;

namespace dharmendraPradhan.Data
{
    public class StatusBoothAgentContext:DbContext
    {
        public StatusBoothAgentContext(DbContextOptions<StatusBoothAgentContext> options):base(options)
        {
            
        }
        public DbSet<StatusBoothAgentModel> StatusBoothAgents { get; set; }

    }
}
