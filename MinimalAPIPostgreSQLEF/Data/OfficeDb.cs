using Microsoft.EntityFrameworkCore;
using MinimalAPIPostgreSQLEF.Models;

namespace MinimalAPIPostgreSQLEF.Data
{
    public class OfficeDb: DbContext
    {
        public OfficeDb(DbContextOptions<OfficeDb> options) : base(options)
        {
            
        }
        public DbSet<Employee> Employees => Set<Employee>();
    }
}
