using Dapper.Application.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;
using Dapper.Core.Entities;
using Dapper.Infrastructure.Mappers;
using DapperExtensions;
using DapperExtensions.Sql;
using Npgsql;
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
        }
        public async Task<Guid> AddAsync(Device entity)
        {
            DapperExtensions.DapperExtensions.SetMappingAssemblies
            (

                    AppDomain.CurrentDomain
                    .GetAssemblies()
                    .ToArray()


            );
            DapperExtensions.DapperExtensions.DefaultMapper = typeof(DeviceMapper);
            //DapperExtensions.DapperExtensions.SqlDialect = new PostgreSqlDialect();
            //DapperAsyncExtensions.SqlDialect = new PostgreSqlDialect();
            using (IDbConnection db = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                //DapperExtensions.DapperExtensions.DefaultMapper = typeof(DeviceMapper);
                /*DapperExtensions.DapperExtensions.SetMappingAssemblies
                (
                    new[]
                    {
                        Assembly.GetAssembly(typeof(DeviceMapper))
                    }
                ); */
                

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