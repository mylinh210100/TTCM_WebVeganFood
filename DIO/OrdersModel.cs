using DAO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagedList;
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
        public IEnumerable<Order> ListAll(int page, int pSz)
        {
            //var listall = context.Database.SqlQuery<Order>("sp_View_Order").ToList();
            return context.Orders.OrderBy(o => o.IdOrder).ToPagedList(page, pSz);
        }

    }
}
