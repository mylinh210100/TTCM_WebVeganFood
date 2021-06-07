using DAO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO
{
    public class OrdersModel
    {
        private DBWebsite context = null;
        public OrdersModel()
        {
            context = new DBWebsite();
        }
        public List<Order> ListAll()
        {
            var listall = context.Database.SqlQuery<Order>("sp_View_Order").ToList();
            return listall;
        }

    }
}
