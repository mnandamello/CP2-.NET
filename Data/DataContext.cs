using CP2_.NET.Models;
using Microsoft.EntityFrameworkCore;

namespace CP2_.NET.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)

        {
        }

        public DbSet<User> MVC_USUARIOS { get; set; }
    }
}



