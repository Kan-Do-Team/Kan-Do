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
            options.UseSqlServer("Server=nasirdomain.ddns.net, 1433\\KANDOSERVER; Database=KanDoDB; User Id=sa; Password=CPS8882022; Trusted_Connection=false;");

            return new KanDoDbContext(options.Options);
        }
    }
}
