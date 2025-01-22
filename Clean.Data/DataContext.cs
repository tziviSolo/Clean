using Clean.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Data
{
    public class DataContext
    {
        public List<Client> clientsLst { get; set; }
        public List<Order> ordersLst { get; set; }
        public DataContext()
        {
            clientsLst = new List<Client>() {
                new Client(){ Id = 1, FirstName = "Chavi", LastName = "Solo"},
                new Client(){ Id = 2, FirstName = "Malki", LastName = "Blau"},
                new Client(){ Id = 3, FirstName = "Sara", LastName = "Magnuz"},
                new Client(){ Id = 4, FirstName = "Lea", LastName = "Levi"},
                new Client(){ Id = 5, FirstName = "Shevi", LastName = "Cohen"},
                new Client(){ Id = 6, FirstName = "Shifi", LastName = "Putermilech"}
            };

            ordersLst = new List<Order>();
        }
    }
}
