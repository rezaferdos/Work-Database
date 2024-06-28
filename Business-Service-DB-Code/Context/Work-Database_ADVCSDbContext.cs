using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Service_DB_Code.Model;

namespace Business_Service_DB_Code.Context;

public class Work_Database_ADVCSDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString: "Server=.;Database=Work-Database_ADVCS;User Id=sa;Password=828898;TrustServerCertificate=True;Integrated Security=true;");
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<User> Users { get; set; }
}
