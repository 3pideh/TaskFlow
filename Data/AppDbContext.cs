using Microsoft.EntityFrameworkCore;
using TaskFlowApi.Entities;

namespace TaskFlowApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<User> users => Set<User>();

        public DbSet<TaskItem> Tasks => Set<TaskItem>(); //getter only

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasMany(u => u.TaskItems)
                .WithOne(t => t.User)
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>().HasData(
       new User
       {
           Id = Guid.Parse("11111111-1111-1111-1111-111111111111"), // یک GUID ثابت
           Username = "admin",
           Email = "admin@taskflow.com"
       }
   );
        }
    }
}
