using Dapper.Application.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;
using Dapper.Core.Entities;
using Dapper.Infrastructure.Mappers;
using DapperExtensions;
using System.Data;
using System.Reflection;


namespace Dapper.Infrastructure.Repositories
{

    public class DeviceRepository : IDeviceRepository
    {
        private readonly IConfiguration _configuration;
        public DeviceRepository(IConfiguration configuration)
        {
            _configuration = configuration;

            DapperExtensions.DapperExtensions.DefaultMapper = typeof(DeviceMapper);
            
            DapperExtensions.DapperExtensions.SetMappingAssemblies
                (
                    new[] { typeof (DeviceMapper).Assembly}
                );

        }
        public async Task<Guid> AddAsync(Device entity)
        {
            
            using (IDbConnection db = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {

                db.Open();
               
                Guid id = await db.InsertAsync(entity);
                
                return id;
            }
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