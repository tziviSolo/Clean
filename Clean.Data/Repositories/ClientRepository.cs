using Clean.Core.Entities;
using Clean.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Data.Repositories
{
    //Client הפונקציות שאפשר להפעיל על אוביקט מטיפוס  
    public class ClientRepository : IClientRepository
    {
        private readonly DataContext _dataContext;
        public ClientRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Client> GetClients()
        {
            return _dataContext.clientsLst.ToList();
        }
    }
}
