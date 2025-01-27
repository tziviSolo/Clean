using Clean.Core.Entities;
using Clean.Core.Services;
using Clean.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Clean.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController(IService<Order> orderService) : ControllerBase
    {
        private readonly IService<Order> _orderService = orderService;

        // GET: api/<OrdersController>
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return _orderService.GetAll();
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public Order? Get(int id)
        {
            return _orderService.GetById(id);
        }

        // POST api/<OrdersController>
        [HttpPost]
        public void Post([FromBody] Order order)
        {
            _orderService.Add(order);
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Order order)
        {
            _orderService.Update(id, order);
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _orderService.Delete(id);
        }
    }
}
