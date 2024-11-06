using dharmendraPradhan.Models;
using Microsoft.EntityFrameworkCore;

namespace dharmendraPradhan.Data
{
    public class StatusLocalPeopleContext : DbContext
    {
        public StatusLocalPeopleContext(DbContextOptions<StatusLocalPeopleContext> options) : base(options)
        {
        }

        public DbSet<StatusLocalPeopleModel> StatusLocalPeople { get; set; }
    }
}
