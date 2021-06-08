using System;
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
    }
}