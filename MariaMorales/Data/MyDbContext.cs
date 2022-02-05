using MariaMorales.Models;
using Microsoft.EntityFrameworkCore;

namespace MariaMorales.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)   
        {

        }
        public DbSet <Cliente> Cliente { get; set; }
    }
}
