using Abp.Zero.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TeslaSoft.Authorization.Roles;
using TeslaSoft.Authorization.Users;
using TeslaSoft.Entities;
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

        public virtual DbSet<Aspirantes> Aspirantes { get; set; }
        public virtual DbSet<Licencias> Licencias { get; set; }
        public virtual DbSet<Licencias_Restricciones> Licencias_Restricciones { get; set; }
        public virtual DbSet<Restricciones> Restricciones { get; set; }
        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<Licencias_Categoriass> Licencias_Categoriass { get; set; }
    }
   
}
