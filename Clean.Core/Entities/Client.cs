﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Core.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //רשימת הצילומים שהקליינט הזמין
        public List<Order> Orders { get; set; }

        public override string ToString()
        {
            return $"Email : {Email} ,FirstName : {FirstName}";
        }
    }
}
