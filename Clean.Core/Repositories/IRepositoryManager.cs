﻿using Clean.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Core.Repositories
{
    public interface IRepositoryManager
    {
        IEntityRepository<Client> Clients { get; }
        IEntityRepository<Order> Orders { get; }
        void Save();
    }
}
