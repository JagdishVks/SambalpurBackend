using dharmendraPradhan.Models;
using Microsoft.EntityFrameworkCore;



namespace dharmendraPradhan.Data
{
    public class StatusMainLocalDemandContext:DbContext
    {
        public StatusMainLocalDemandContext(DbContextOptions<StatusMainLocalDemandContext> options)
            : base(options)
        {
        }

        public DbSet<StatusMainLocalDemandModel> StatusMainLocalDemand { get; set; }
    }
}
