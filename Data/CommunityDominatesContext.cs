using dharmendraPradhan.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dharmendraPradhan.Data
{
    public class CommunityDominatesContext : DbContext
    {
        public CommunityDominatesContext(DbContextOptions<CommunityDominatesContext> options)
            : base(options)
        {
        }

        public DbSet<CommunityDominatesModel> CommunityDominates { get; set; }
    }
}
