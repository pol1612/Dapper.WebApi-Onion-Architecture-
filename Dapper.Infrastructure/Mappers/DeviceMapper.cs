using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Core.Entities;
using DapperExtensions.Mapper;

namespace Dapper.Infrastructure.Mappers
{
    public sealed class DeviceMapper : PluralizedAutoClassMapper<Device> 
    {
        public DeviceMapper() : base()
        {
            throw new NotImplementedException();
            Schema("public");
            Table("Devices");
            Console.WriteLine("it maps");
            Map(x => x.Id).Key(KeyType.Guid);
            AutoMap();
        }
    }
}
