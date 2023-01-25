using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Inventory.Indexex
{
    public  class AuditiedIndexEntity : AuditedAggregateRoot<int>, IMustHaveTenant
    {
        public int TenantId { get; set; }

        public string Name { get; set; }

        public int Order { get; set; }
    }
}
