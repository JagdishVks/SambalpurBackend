using dharmendraPradhan.Models;
using Microsoft.EntityFrameworkCore;

namespace dharmendraPradhan.Data
{
    public class StatusSocialMediaActContext:DbContext
    {
        public StatusSocialMediaActContext(DbContextOptions<StatusSocialMediaActContext> options) : base(options) 
        { 
        }

        public DbSet<StatusSocialMediaActModel> SocialMediaActivist { get; set; }
    }
}
