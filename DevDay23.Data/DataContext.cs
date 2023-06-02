using DevDay23.Domain;
using Microsoft.EntityFrameworkCore;

namespace DevDay23.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions <DataContext> options) : base(options) { }
        public DbSet<Student>Student { get; set; }
        
    }
}
