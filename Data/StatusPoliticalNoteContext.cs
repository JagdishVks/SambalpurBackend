using dharmendraPradhan.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dharmendraPradhan.Data
{
    public class StatusPoliticalNoteContext(DbContextOptions<StatusPoliticalNoteContext > options) : DbContext(options)
    {

        public DbSet<StatusPoliticalNoteModel> StatusPoliticalNote { get; set; }

    }
}
