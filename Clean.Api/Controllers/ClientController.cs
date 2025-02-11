using Clean.Core.Entities;
using Clean.Core.Repositories;
using Clean.Core.Services;
using Clean.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Clean.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ClientController(IService<Client> clientService, IRepositoryManager repositoryManager) : ControllerBase
    {
        private readonly IService<Client> _clientService = clientService;
        private readonly IRepositoryManager _repositoryManager = repositoryManager;

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
            return _clientService.GetById(id);
        }

        // POST api/<ClientController>
        [HttpPost]
        public ActionResult Post([FromBody] Client newClient)
        {
            var posted = _clientService.Add(newClient);
            _repositoryManager.Save();
            return Ok(posted);
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Client updatedClient)
        {
            var updated = _clientService.Update(id, updatedClient);
            _repositoryManager.Save();
            return Ok(updated);
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _clientService.Delete(id);
            _repositoryManager.Save();
        }
    }
}
