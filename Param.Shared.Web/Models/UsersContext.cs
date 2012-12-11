using System.Data.Entity;

namespace Param.Shared.Web.Models
{
    public class UsersContext : DbContext
    {
        public UsersContext()
            : base("DefaultConnection")
        {}

        public DbSet<UserProfile> UserProfiles { get; set; }
    }
}