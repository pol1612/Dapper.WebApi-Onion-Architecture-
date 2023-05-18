using Dapper.Application.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;
using Dapper.Core.Entities;
using Dapper.Infrastructure.Mappers;
using DapperExtensions;
using DapperExtensions.Mapper;
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

            DapperExtensions.DapperExtensions.DefaultMapper = typeof(PluralizedAutoClassMapper<>);
            
            DapperExtensions.DapperExtensions.SetMappingAssemblies
                (
                    new[] { typeof (PluralizedAutoClassMapper<>).Assembly}
                );

        }
        public async Task<Guid> AddAsync(Device entity)
        {

            

            using (IDbConnection db = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                DapperExtensions.DapperAsyncExtensions.DefaultMapper = typeof(DeviceMapper);
                DapperExtensions.DapperExtensions.SetMappingAssemblies
                (
                    new[] { typeof(DeviceMapper).Assembly }
                );

                db.Open();
                
                Guid id = await db.InsertAsync<Device>(entity);
                
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