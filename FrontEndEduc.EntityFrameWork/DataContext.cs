using FrontEndEduc.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FrontEndEduc.EntityFrameWork
{
    public class DataContext : DbContext
    {
        public DbSet<WorkItemEntity> WorkItems { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}