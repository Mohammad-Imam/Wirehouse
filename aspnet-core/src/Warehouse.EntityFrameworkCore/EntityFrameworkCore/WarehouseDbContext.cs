﻿using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Warehouse.Authorization.Roles;
using Warehouse.Authorization.Users;
using Warehouse.MultiTenancy;
using Warehouse.Inventory.Aggregates;
using Warehouse.Inventory.Indexex;

namespace Warehouse.EntityFrameworkCore
{
    public class WarehouseDbContext : AbpZeroDbContext<Tenant, Role, User, WarehouseDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public WarehouseDbContext(DbContextOptions<WarehouseDbContext> options)
            : base(options)
        {
        }


        public DbSet<Storehouse> Storehouses { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<StorehouseType> StorehouseType { get; set; }


    }
}
