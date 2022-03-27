using Microsoft.EntityFrameworkCore;
using Kan_Do.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kan_Do.EntityFramework
{
    public class KanDoDbContext : DbContext
    {
        

        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public KanDoDbContext(DbContextOptions options) : base(options) { }

    }
}
