using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Inventory.Aggregates;
using Warehouse.Inventory.Storehouses.Dto;

namespace Warehouse.Inventory.Storehouses.Map
{
    public class StorehouseMapProfile : Profile
    {
        public StorehouseMapProfile()
        {
            CreateMap<Storehouse, StorehouseDto>();
        }
    }
}
