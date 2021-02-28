using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Steps_Assignment.Data.Entities;

namespace Data
{
    public class ItemsContext : DbContext
    {
        public ItemsContext(DbContextOptions<ItemsContext> options) : base(options)
        {

        }
        public DbSet<Step> Steps { get; set; }
        public DbSet<Item> Items { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Step>().HasKey(c => c.Id);
            modelBuilder.Entity<Item>().HasKey(c => c.Id);
            modelBuilder.Entity<Item>().HasOne(c => c.Step).WithMany(c => c.Items).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Step>().HasData(new Step
            {
                Id = 1,
                StepNumber = 1
            });
            modelBuilder.Entity<Step>().HasData(new Step
            {
                Id = 2,
                StepNumber = 2
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                Id = 1,
                Title = "title 1",
                Description = "description 1",
                StepId = 1
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                Id = 2,
                Title = "title 2",
                Description = "description 2",
                StepId = 1
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                Id = 3,
                Title = "title 1",
                Description = "description 1",
                StepId = 2
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
