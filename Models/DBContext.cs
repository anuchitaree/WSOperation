using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSOperation.Models
{
    public class DBContext : DbContext
    {




        public DbSet<Account> Accounts { get; set; } = null!;
        public DbSet<WorkingStandard> WorkingStandards { get; set; } = null!;

    }
}
