using Microsoft.EntityFrameworkCore;

namespace EntertainmentApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)         
        {

        }
    }
}
