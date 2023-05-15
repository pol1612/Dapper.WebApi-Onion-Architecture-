using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Application.Interfaces;

namespace Dapper.Infrastructure.UnitsOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public IDeviceRepository Devices {get;}

        public UnitOfWork(IDeviceRepository deviceRepository)
        {
            Devices = deviceRepository;
        }
    }
}
