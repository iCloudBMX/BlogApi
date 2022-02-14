using BlogForEducation.Domain.Models;
using BlogForEducation.Infrastructure.Context;
using BlogForEducation.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlogForEducation.Infrastructure.Repositories
{
    // User - IUser
    // Blog - IBlog

    public class UserRepositoryAsync : GenericRepositoryAsync<User>,IUserRepositoryAsync
    {
        private readonly DbSet<User> _users;

        public UserRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
            _users = dbContext.Set<User>();
        }
    }
}
