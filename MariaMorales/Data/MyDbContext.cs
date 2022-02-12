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
        public DbSet<Pago> Pago { get; set; }
        public DbSet<Prestamo> Prestamo { get; set; }
    }
}
