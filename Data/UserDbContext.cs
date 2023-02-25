using Microsoft.EntityFrameworkCore;
using UserRegistrationAPI.Models;

namespace UserRegistrationAPI.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }

        public DbSet<UserMaster> Users { get; set; }

        public DbSet<StateMaster> StateLists { get; set; }
    }
}
