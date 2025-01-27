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
    public class ClientService(IEntityRepository<Client> clients) : IService<Client>
    {
        private readonly IEntityRepository<Client> _clientRepository = clients;

        public IEnumerable<Client> GetAll()
        {
            return _clientRepository.GetAll();
        }

        public Client? GetById(int id)
        {
            return _clientRepository.GetById(id);
        }

        public void Add(Client client)
        {
            _clientRepository.Add(client);
        }

        public void Update(int id, Client client)
        {
            _clientRepository.Update(id, client);
        }
        public void Delete(int id)
        {
            _clientRepository.Delete(id);
        }
    }
}
