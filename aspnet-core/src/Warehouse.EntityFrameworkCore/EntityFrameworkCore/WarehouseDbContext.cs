using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Warehouse.Authorization.Roles;
using Warehouse.Authorization.Users;
using Warehouse.MultiTenancy;

namespace Warehouse.EntityFrameworkCore
{
    public class WarehouseDbContext : AbpZeroDbContext<Tenant, Role, User, WarehouseDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public WarehouseDbContext(DbContextOptions<WarehouseDbContext> options)
            : base(options)
        {
        }
    }
}
