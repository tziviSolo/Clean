﻿using Clean.Core.Entities;
using Clean.Core.Repositories;
using Clean.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Service
{
    public class ClientService(IEntityRepository<Client> clients) : IClientService
    {
        private readonly IEntityRepository<Client> _clientRepository = clients;

        public List<Client> GetAll()
        {
            return _clientRepository.GetAll().ToList();
        }
    }
}
