using Microsoft.EntityFrameworkCore;
using SS_API.Model;

namespace SS_API.Data
{
    public class StreamerContext : DbContext
    {
        public StreamerContext(DbContextOptions<StreamerContext> option) : base(option) {}

        public DbSet<CourseModel> Courses { get; set; }
    }
}