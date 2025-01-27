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
    public class OrderService(IEntityRepository<Order> orders) : IOrderService
    {
        private readonly IEntityRepository<Order> _clientRepository = orders;

        public List<Order> GetAll()
        {
            return _clientRepository.GetAll().ToList();
        }
    }
}
