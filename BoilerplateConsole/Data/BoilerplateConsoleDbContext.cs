using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoilerplateConsole.Data
{
    public class BoilerplateConsoleDbContext : DbContext
    {
        public BoilerplateConsoleDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
