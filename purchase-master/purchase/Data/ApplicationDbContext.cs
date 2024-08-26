using Microsoft.EntityFrameworkCore;
using purchase.Models;


namespace purchase.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        } 
        public DbSet <Checkout> Checkouts { get; set; }

    }   
}
