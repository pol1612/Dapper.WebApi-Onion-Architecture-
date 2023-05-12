using Dapper.Application.Interfaces;
using Dapper.Core.Entities;

namespace Dapper.Infrastructure
{

    public class DeviceRepository : IDeviceRepository
    {
        public Task<int> AddAsync(Device entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Device>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Device> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Device entity)
        {
            throw new NotImplementedException();
        }
    }
}