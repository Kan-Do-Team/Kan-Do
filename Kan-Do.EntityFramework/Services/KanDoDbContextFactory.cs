using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kan_Do.EntityFramework.Services
{
    public class KanDoDbContextFactory
    {
        public KanDoDbContext CreateDbContext()
        {
            var config = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddUserSecrets<KanDoDbContextFactory> ()
            .Build();

            var option = new DbContextOptionsBuilder<KanDoDbContext>();
            option.UseSqlServer(config.GetConnectionString("defaultDB"));

            return new KanDoDbContext(option.Options);
        }
    }
}
