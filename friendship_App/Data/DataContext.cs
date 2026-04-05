

using friendship_App.Entities;
using Microsoft.EntityFrameworkCore;
namespace friendship_App.Data
{
    public class DataContext(DbContextOptions options) : DbContext(options)
    {
       
            public DbSet<AppUser> Users { get; set; }
    
    }

        
    
}
