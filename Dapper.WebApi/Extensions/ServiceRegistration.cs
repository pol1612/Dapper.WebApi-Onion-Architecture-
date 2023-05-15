using Dapper.Infrastructure.Repositories;
using Dapper.Infrastructure.UnitsOfWork;
using Dapper.Application.Interfaces;

namespace Dapper.WebApi.Extensions
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IDeviceRepository, DeviceRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
