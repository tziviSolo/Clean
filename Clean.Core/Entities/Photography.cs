using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Core.Entities
{
    public class Photography
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        //רשימת ההזמנות שבהם הזמינו את סוג הצילום הזה
        public List<Order> Orders { get; set; }
    }
}
