using _12_MVC_FutbolOrnek.Controllers;
using Microsoft.EntityFrameworkCore;

 public  class ApplicationDbContext:DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    public DbSet<Futbolcu> Futbolcular { get; set; }
    public DbSet<Mevki> Mevkiler { get; set; }
    public DbSet<Takim> Takimlar { get; set; }

}