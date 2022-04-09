using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kan_Do.EntityFramework
{
    public class KanDoDbContextFactory : IDesignTimeDbContextFactory<KanDoDbContext>
    {
        public KanDoDbContext CreateDbContext(string[]? args = null)
        {
            var options = new DbContextOptionsBuilder<KanDoDbContext>();
            options.UseSqlServer("Server=DESKTOP-N\\KANDOSERVER; Database=KanDoDB; Trusted_Connection=true;");

            return new KanDoDbContext(options.Options);
        }
    }
}
