using dharmendraPradhan.Models;
using Microsoft.EntityFrameworkCore;



namespace dharmendraPradhan.Data
{
    public class StatusCommunityPeopleContext : DbContext
    {
        public StatusCommunityPeopleContext(DbContextOptions<StatusCommunityPeopleContext> options)
            : base(options)
        {
        }

        public DbSet<StatusCommunityPeopleModel> StatusCommunityPeople  { get; set; }
    }
}
