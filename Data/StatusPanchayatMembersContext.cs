using dharmendraPradhan.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace dharmendraPradhan.Data
{
    public class StatusPanchayatMembersContext(DbContextOptions<StatusPanchayatMembersContext> options) : DbContext(options)
    {
        public DbSet<StatusPanchayatMemweberModel> StatusPanchayatMember { get; set; }
       
    }
}
