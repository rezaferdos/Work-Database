using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_EF_CodeFirst.Models.Context;

public class Work_Database_ADVCSDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Wrong Way To Hardcode
        optionsBuilder.UseSqlServer(connectionString: "Server=.;Database=Work-Database_ADVCS;User Id=sa;Password=828898;TrustServerCertificate=True;Integrated Security=true;");
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<User> Users { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Province> Provinces { get; set; }
    public DbSet<Country> Countries{ get; set; }
}
