using dharmendraPradhan.Models;
using dharmendraPradhan.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace dharmendraPradhan.Data
{
    public class StatusMainWorkerContext : DbContext
    {

        public StatusMainWorkerContext(DbContextOptions<StatusMainWorkerContext> options) : base(options)
        {
        }


        public DbSet<StatusMainWorkerModel> StatusMainWorkers { get; set; }
    }
}
