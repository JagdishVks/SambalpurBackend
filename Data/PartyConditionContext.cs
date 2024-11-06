using dharmendraPradhan.Models;
using Microsoft.EntityFrameworkCore;



namespace dharmendraPradhan.Data
{
    public class PartyConditionContext : DbContext
    {
        public PartyConditionContext(DbContextOptions<PartyConditionContext> options)
            : base(options)
        {
        }

        public DbSet<PartyCondtionModel> PartyCondition { get; set; }
    }
}
