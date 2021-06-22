﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webVegankitchen.Common
{
    [Serializable]
    public class UserLogin
    {
        public long Id { get; set; }
        public string UserName { get; set; }

        public int IdCustomer { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}