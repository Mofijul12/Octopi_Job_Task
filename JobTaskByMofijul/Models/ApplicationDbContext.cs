using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace JobTaskByMofijul.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Alice", Email = "alice@example.com", Age = 25, Status = "Active" },
                new User { Id = 2, Name = "Bob", Email = "bob@example.com", Age = 30, Status = "Inactive" },
                new User { Id = 3, Name = "Charlie", Email = "charlie@example.com", Age = 22, Status = "Active" },
                new User { Id = 4, Name = "David", Email = "david@example.com", Age = 27, Status = "Active" },
                new User { Id = 5, Name = "Eve", Email = "eve@example.com", Age = 29, Status = "Inactive" },
                new User { Id = 6, Name = "Frank", Email = "frank@example.com", Age = 31, Status = "Active" },
                new User { Id = 7, Name = "Grace", Email = "grace@example.com", Age = 26, Status = "Inactive" },
                new User { Id = 8, Name = "Hank", Email = "hank@example.com", Age = 28, Status = "Active" },
                new User { Id = 9, Name = "Ivy", Email = "ivy@example.com", Age = 24, Status = "Inactive" },
                new User { Id = 10, Name = "Jack", Email = "jack@example.com", Age = 35, Status = "Active" }
            );
        }
    }

}
