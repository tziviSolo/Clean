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
        private readonly IEntityRepository<Order> _orderRepository = orders;

        public IEnumerable<Order> GetAll()
        {
            return _orderRepository.GetAll();
        }

        public Order? GetById(int id)
        {
            return _orderRepository.GetById(id);
        }
        public Order Add(Order order)
        {
            var added = _orderRepository.Add(order);
            return added;
        }

        public Order Update(int id, Order order)
        {
           var updated = _orderRepository.Update(id, order);
            return updated;
        }
        public void Delete(int id)
        {
            _orderRepository.Delete(id);
        }
    }
}
