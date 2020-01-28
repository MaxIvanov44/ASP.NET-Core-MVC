﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_MVC.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string User { get; set; } 
        public string Address { get; set; } 
        public string ContactPhone { get; set; } 
        public int PhoneId { get; set; } 
        public Phone Phone { get; set; }
    }
}
