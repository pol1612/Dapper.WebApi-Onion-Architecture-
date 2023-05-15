using MyProject.Dapper.Application.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;
using MyProject.Dapper.Core.Entities;
using Dapper;

namespace MyProject.Dapper.Infrastructure
{

    public class DeviceRepository : IDeviceRepository
    {
        private readonly IConfiguration _configuration;
        public DeviceRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public Task<Guid> AddAsync(Device entity)
        {
        }

        public Task<Guid> DeleteAsync(Guid id)
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

        public Task<Guid> UpdateAsync(Device entity)
        {
            throw new NotImplementedException();
        }
    }
}