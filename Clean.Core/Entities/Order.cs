using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Core.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        public Photography Photography { get; set; }
        public DateTime DateOfOrder { get; set; }
        public DateTime DateOfPictures { get; set; }
    }
}
