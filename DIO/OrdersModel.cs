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
        public IEnumerable<Order> ListAll(string search, int page, int pSz)
        {
            IQueryable<Order> model = context.Orders;
            if (!string.IsNullOrEmpty(search))
            {
                model = model.Where(f => f.IdFoundation.ToString().Contains(search) || f.IdCustomer.ToString().Contains(search));
            }
            return model.OrderBy(f => f.IdOrder).ToPagedList(page, pSz);
        }

    }
}
