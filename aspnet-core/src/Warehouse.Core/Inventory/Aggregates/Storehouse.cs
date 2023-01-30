using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Inventory.Indexex;

namespace Warehouse.Inventory.Aggregates
{
    public class Storehouse : AuditedAggregateRoot<Guid> ,IMustHaveTenant
    {
        public int TenantId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public StorehouseType StorehouseType { get; set; }

        public City City { get; set; }

        public Country Country { get; set; }
    }
}
