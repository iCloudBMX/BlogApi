using BlogForEducation.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogForEducation.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {  }

        public DbSet<User> Users { get; set; }
    }
}
