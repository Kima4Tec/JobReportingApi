using JobReportingApi.Models;
using Microsoft.EntityFrameworkCore;

namespace JobReportingApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Companies> Company { get; set; }
    }
}
