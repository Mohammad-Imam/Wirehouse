using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Warehouse.EntityFrameworkCore
{
    public static class WarehouseDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<WarehouseDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<WarehouseDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
