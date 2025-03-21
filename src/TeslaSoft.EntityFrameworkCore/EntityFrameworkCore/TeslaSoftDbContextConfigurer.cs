using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace TeslaSoft.EntityFrameworkCore
{
    public static class TeslaSoftDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TeslaSoftDbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TeslaSoftDbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}
