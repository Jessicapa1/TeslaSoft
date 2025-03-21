using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TeslaSoft.Authorization.Roles;
using TeslaSoft.Authorization.Users;
using TeslaSoft.MultiTenancy;

namespace TeslaSoft.EntityFrameworkCore
{
    public class TeslaSoftDbContext : AbpZeroDbContext<Tenant, Role, User, TeslaSoftDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public TeslaSoftDbContext(DbContextOptions<TeslaSoftDbContext> options)
            : base(options)
        {
        }
    }
}
