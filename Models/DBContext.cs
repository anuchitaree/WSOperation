using Microsoft.EntityFrameworkCore;
using WSOperation.Modules;

namespace WSOperation.Models
{
    public class DBContext : DbContext
    {




        public DbSet<Account> Accounts { get; set; } = null!;
        public DbSet<WorkingStandard> WorkingStandards { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            Param.ConnectionString= @"User ID =postgres;Server=localhost;Port=5432;Database=WSstorage;Username=postgres;Password=admin;Integrated Security=true;Pooling=true;";
         
            optionsBuilder.UseNpgsql(Param.ConnectionString);
        }


    }


}
