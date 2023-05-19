using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Core.Entities;
using DapperExtensions.Mapper;

namespace Dapper.Infrastructure.Mappers
{
    public class DeviceMapper : ClassMapper<Device> 
    {
        public DeviceMapper()
        {
            //throw new NotImplementedException();   
            ClassMapper<Device> classMapper = new ClassMapper<Device>();
            
            Schema("dbo");
            Table("Devices");
            Console.WriteLine("it maps");
            Map(x => x.Id).Key(KeyType.Guid);
            AutoMap();
        }
    }
}
