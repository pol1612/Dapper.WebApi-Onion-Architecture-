using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Core.Entities;
using DapperExtensions.Mapper;

namespace Dapper.Infrastructure.Mappers
{
    public class DeviceMapper : AutoClassMapper<Device>
    {
        public DeviceMapper()
        {
            
            Schema("dbo");
            Table("Devices");
            Console.WriteLine("it maps");
            AutoMap();
        }
    }
}
