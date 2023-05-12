using Dapper.Application.Interfaces;
using Dapper.Core.Entities;
namespace Dapper.Infrastructure
{
    public class DeviceRepository : IDeviceRepository
    {
        public Task<Device> GetByIdAsync(int id)
        {
            return DeviceRepository.GetByIdAsync(id);
        }
    }
}