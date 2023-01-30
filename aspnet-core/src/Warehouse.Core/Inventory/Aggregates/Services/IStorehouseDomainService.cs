using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Inventory.Aggregates.Services
{
    public interface IStorehouseDomainService:IDomainService
    {
        IList<Storehouse> GetAll();
        
        Task<IList<Storehouse>> GetAllAsync();
        
        Task <Storehouse> GetById(Guid id);

        Task <Storehouse> GetByName(string name);
        
        Task<Storehouse> Add(Storehouse storehouse);

        void Update(Storehouse storehouse);

        void Delete(Guid id);




    }
}
