using Microsoft.EntityFrameworkCore;
using WebAPIprc.Models;

namespace WebAPIprc.Context
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>contextOptions)
            : base(contextOptions)
        { 
        }

        public  DbSet<Employees>Employees {  get; set; }
    }
}
