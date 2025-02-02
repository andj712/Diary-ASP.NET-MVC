using DiaryApp.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Controllers.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) {
        


        }   

        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            

            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry
                {
                    Id = 1,
                    Title = "Went Swimming",
                    Content = "With Alex",
                    Created = new DateTime(2024, 02, 01, 10, 30, 00, DateTimeKind.Utc)
                },
                new DiaryEntry
                  {
                      Id = 2,
                      Title = "Went Walking",
                      Content = "With Maria",
                    Created = new DateTime(2024, 02, 01, 10, 30, 00,DateTimeKind.Utc)
                },
                new DiaryEntry
                  {
                        Id = 3,
                        Title = "Went Shopping",
                        Content = "With Sofia",
                        Created = new DateTime(2024, 02, 01, 10, 30, 00, DateTimeKind.Utc)

                }

                );
        }
    }
}
