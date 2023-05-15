using Microsoft.AspNetCore.Mvc;
using MyProject.Dapper.Core.Entities;
using MyProject.Dapper.Infrastructure.Repositories;
using MyProject.Dapper.Application.Interfaces;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyProject.Dapper.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevicesController : ControllerBase
    {
        private DeviceRepository deviceRepository;
        public DevicesController(IDeviceRepository deviceRepository)
        {
            this.deviceRepository =(DeviceRepository) deviceRepository;
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
            var id = await deviceRepository.AddAsync(device);
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
