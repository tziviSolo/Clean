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
    public class ClientService:IClientService
    {
        private readonly IClientRepository _clientRepository;
        public ClientService(IClientRepository client)
        {
            _clientRepository = client;
        }

        public List<Client> GetAll()
        {
            return _clientRepository.GetClients();
        }
    }
}
