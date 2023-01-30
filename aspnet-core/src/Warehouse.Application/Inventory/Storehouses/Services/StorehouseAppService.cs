using AutoMapper.Internal.Mappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Inventory.Aggregates;
using Warehouse.Inventory.Aggregates.Services;
using Warehouse.Inventory.Storehouses.Dto;

namespace Warehouse.Inventory.Storehouses.Services
{
    [AllowAnonymous]
    public class StorehouseAppService : WarehouseAppServiceBase, IStorehouseAppService
    {

        private readonly IStorehouseDomainService _storehouseDomainService;

        public StorehouseAppService(IStorehouseDomainService storehouseDomainService)
        {
            _storehouseDomainService = storehouseDomainService;
        }

        [HttpPost]
        public async Task<StorehouseDto> Add([FromBody] StorehouseDto storehouseDto)
        {
            var storehouse= ObjectMapper.Map<Storehouse>(storehouseDto);

            //return await _storehouseDomainService.Add(storehouse);

            return  new StorehouseDto();
        }

        [HttpDelete("api/services/app/Storehouse/Delete/{id}")]
        public void Delete(int id)
        {
            //_storehouseDomainService.Delete(id);
        }

        [Authorize("Employee")]
        [HttpGet]
        public IList<StorehouseDto> GetAll()
        {
            var storehouses = _storehouseDomainService.GetAll();
            var storehousesDto = ObjectMapper.Map<List<StorehouseDto>>(storehouses);
            return storehousesDto;
        }

        [HttpGet]
        public async Task<IList<StorehouseDto>> GetAllsAsync()
        {
            var storehouses = await _storehouseDomainService.GetAllAsync();
            var storehousesDto = ObjectMapper.Map<List<StorehouseDto>>(storehouses);
            return storehousesDto;
        }

        [HttpGet]
        public async Task<StorehouseDto> GetById(Guid id)
        {
            var storehouse = await _storehouseDomainService.GetById(id);
            var storehouseDto = ObjectMapper.Map<StorehouseDto>(storehouse);
            return  storehouseDto;
        }

        [HttpGet]
        public async Task<StorehouseDto> GetByName(string name)
        {
            var storehouse = await _storehouseDomainService.GetByName(name);
            var storehouseDto = ObjectMapper.Map<StorehouseDto>(storehouse);
            return storehouseDto;
        }

        [HttpPut]
        public void Update([FromBody] StorehouseDto storehouseDto)
        {
           // _storehouseDomainService.Update(storehouseDto);
        }
    }
}
