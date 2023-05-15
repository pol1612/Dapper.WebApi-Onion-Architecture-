using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MyProject.Dapper.Core.Entities;

namespace MyProject.Dapper.Infrastructure.Databases
{
    public class RainbowDatabase : Database<RainbowDatabase>
    {
        public Table<Device> Devices { get; set; }
    }
}
