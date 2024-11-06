using dharmendraPradhan.Models;
using Microsoft.EntityFrameworkCore;

namespace dharmendraPradhan.Data
{
    public class GetLocIDAndBoothContext : DbContext
    {
        public GetLocIDAndBoothContext(DbContextOptions<GetLocIDAndBoothContext> options)
            : base(options)
        {
        }

        public DbSet<GetLocIDAndBoothModel> GetLocIDAndBooth { get; set; }
    }
}
