using Microsoft.EntityFrameworkCore;
using ToDoApp.Domain.Entities;

namespace ToDoApp.EntityFramework
{
    public class DataContext : DbContext
    {
        public DbSet<WorkItemEntity> WorkItems { get; set; }
        public DbSet<WorkItemRegistrationEntity> WorkItemsRegistrations { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}