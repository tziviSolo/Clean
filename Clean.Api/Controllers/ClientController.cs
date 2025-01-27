using Clean.Core.Entities;
using Clean.Core.Services;
using Clean.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Clean.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ClientController(IClientService clientService) : ControllerBase
    {
        private readonly IClientService _clientService = clientService;

        // GET: api/<ClientController>
        [HttpGet]
        public IEnumerable<Client> Get()
        {
            return _clientService.GetAll();
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public Client? Get(int id)
        {
            return _clientService.GetAll().Find(c => c.Id == id);
        }

        // POST api/<ClientController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
