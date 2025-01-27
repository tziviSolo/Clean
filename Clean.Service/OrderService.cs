using Clean.Core.Entities;
using Clean.Core.Repositories;
using Clean.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Service
{
    public class OrderService(IEntityRepository<Order> orders) : IService<Order>
    {
        private readonly IEntityRepository<Order> _clientRepository = orders;

        public IEnumerable<Order> GetAll()
        {
            return _clientRepository.GetAll();
        }

        public Order? GetById(int id)
        {
            return _clientRepository.GetById(id);
        }
        public void Add(Order order)
        {
            _clientRepository.Add(order);
        }

        public void Update(int id, Order order)
        {
            _clientRepository.Update(id, order);
        }
        public void Delete(int id)
        {
            _clientRepository.Delete(id);
        }
    }
}
