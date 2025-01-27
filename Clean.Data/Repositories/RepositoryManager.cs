using Clean.Core.Entities;
using Clean.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Data.Repositories
{
    public class RepositoryManager(DataContext context, IEntityRepository<Client> clients, IEntityRepository<Order> orders) : IRepositoryManager
    {
        private readonly DataContext _context = context;
        public IEntityRepository<Client> Clients { get; } = clients;
        public IEntityRepository<Order> Orders { get; } = orders;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
