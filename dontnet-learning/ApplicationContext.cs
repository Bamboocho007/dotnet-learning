using dontnet_learning.Models;
using Microsoft.EntityFrameworkCore;

namespace dontnet_learning
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options) { }
        public DbSet<User> Users { get; set; }

    }
}
