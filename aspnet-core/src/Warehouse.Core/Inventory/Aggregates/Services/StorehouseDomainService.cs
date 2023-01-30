using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Inventory.Aggregates.Services
{
    public class StorehouseDomainService : IStorehouseDomainService
    {
        private readonly IRepository<Storehouse, Guid> _repository;

        public StorehouseDomainService(IRepository<Storehouse, Guid> repository)
        {
            _repository = repository;
        }

        public async Task<Storehouse> Add(Storehouse storehouse)
        {
           return await _repository.InsertAsync(storehouse);
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }

        public IList<Storehouse> GetAll()
        {
            return _repository.GetAllList();
        }

        public async Task<IList<Storehouse>> GetAllAsync()
        {
            return await _repository.GetAllListAsync();
        }

        public async Task<Storehouse> GetById(Guid id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task<Storehouse> GetByName(string name)
        {
            return await _repository.FirstOrDefaultAsync(x => x.Name == name);
        }

        public void Update(Storehouse storehouse)
        {
            _repository.Update(storehouse);
        }
    }
}
