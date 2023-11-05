using car_rent.Models;
using Microsoft.EntityFrameworkCore;

namespace car_rent.Context
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> contextOptions)
            : base(contextOptions)
        { 
                   
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Car> Cars { get; set; }

    }
}
