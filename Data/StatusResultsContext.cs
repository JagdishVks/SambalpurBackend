using dharmendraPradhan.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dharmendraPradhan.Data
{
    public class StatusResultsContext(DbContextOptions<StatusResultsContext> options) : DbContext(options)
    {

        public DbSet<StatusResultsModel> StatusResults { get; set; }

    }
}

