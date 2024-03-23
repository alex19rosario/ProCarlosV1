using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ProCarlosV1.EntityFrameworkCore
{
    public static class ProCarlosV1DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ProCarlosV1DbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ProCarlosV1DbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
