using dharmendraPradhan.Models;
using Microsoft.EntityFrameworkCore;



namespace dharmendraPradhan.Data
{
    public class StatusImportantGroupsContext : DbContext
    {
        public StatusImportantGroupsContext(DbContextOptions<StatusImportantGroupsContext> options)
            : base(options)
        {
        }

        public DbSet<StatusImportantGroupsModel> StatusImportantGroups { get; set; }
    }
}
