using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Inventory.Storehouses.Dto
{
    public class StorehouseDto : EntityDto<Guid>
    {
        public int TenantId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        
    }
}
