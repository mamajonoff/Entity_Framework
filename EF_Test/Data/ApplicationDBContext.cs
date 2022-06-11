using EF_Test.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Test.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}
