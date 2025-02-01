using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Controllers.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) {
        


        }   

        public DbSet<DiaryEntry> DiaryEntries { get; set; } 
        
    }
}
