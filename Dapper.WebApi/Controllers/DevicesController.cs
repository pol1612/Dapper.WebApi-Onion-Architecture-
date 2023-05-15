using Microsoft.AspNetCore.Mvc;
using Dapper.Core.Entities;
using Dapper.Infrastructure.Repositories;
using Dapper.Application.Interfaces;
using Dapper.Infrastructure.UnitsOfWork;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyProject.Dapper.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevicesController : ControllerBase
    {
        private IUnitOfWork UnitOfWork;
        public DevicesController(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }
        // GET: api/<DevicesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DevicesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DevicesController>
        [HttpPost]
        public async Task<Guid> Post([FromBody] Device device)
        {
            var id = await UnitOfWork.Devices.AddAsync(device);
            return id;
        }

        // PUT api/<DevicesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DevicesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
