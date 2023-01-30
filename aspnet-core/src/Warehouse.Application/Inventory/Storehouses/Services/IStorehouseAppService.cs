using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Inventory.Aggregates;
using Warehouse.Inventory.Storehouses.Dto;

namespace Warehouse.Inventory.Storehouses.Services
{
    public interface IStorehouseAppService : IApplicationService
    {
        IList<StorehouseDto> GetAll();

        Task<IList<StorehouseDto>> GetAllsAsync();

        Task<StorehouseDto> GetById(Guid id);

        Task<StorehouseDto> GetByName(string name);

        Task<StorehouseDto> Add(StorehouseDto storehouseDto);

        void Update(StorehouseDto storehouseDto);

        void Delete(int id);
    }
}
