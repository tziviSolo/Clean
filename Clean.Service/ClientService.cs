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

        public Client Add(Client client)
        {
            var added = _clientRepository.Add(client);
            return added;
        }

        public Client Update(int id, Client client)
        {
            var updated = _clientRepository.Update(id, client);
            return updated;
        }
        public void Delete(int id)
        {
            _clientRepository.Delete(id);
        }
    }
}
