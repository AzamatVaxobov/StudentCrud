using Microsoft.EntityFrameworkCore;
using StudentCrud.DataAccess.Entities;

namespace StudentCrud.DataAccess;

public class MainContext : DbContext
{
    public DbSet<Student> Students { get; set; }


    public MainContext(DbContextOptions<MainContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
