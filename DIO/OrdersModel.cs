using DAO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagedList;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace DIO
{
    public class OrdersModel
    {
        private DBWebsite context = null;
        public OrdersModel()
        {
            context = new DBWebsite();
        }
        public IEnumerable<Order> ListAll(string search, int? page)
        {
            int recordsPage = 5;
            if (!page.HasValue)
            {
                page = 1;
            }
            IQueryable<Order> drink = context.Orders;
            try
            {
                if (!string.IsNullOrEmpty(search))
                {
                    drink = drink.Where(f => f.IdCustomer.ToString().Contains(search) || f.IdFoundation.ToString().Contains(search)
                                           || f.TotalCash.ToString().Contains(search) || f.Date.ToString().Contains(search) );

                }
            }
            catch (Exception ex)
            {
            }
            return drink.OrderBy(f => f.IdOrder).ToPagedList(page.Value, recordsPage);
        }
        
        public List<OrderDetail> ViewDetailOrder(int id)
        {
            return context.OrderDetails.Where(c => c.IdOrder == id).ToList();
            
        }

        public List<Foundation> ListID()
        {
            return context.Foundations.Where(f => f.Status == 1).ToList();
        }
        public Order ViewID()
        {
            return context.Orders.OrderByDescending(o => o.IdOrder).FirstOrDefault();
        }

        public List<Order> ViewOrderByIdCus(int idCus)
        {
            return context.Orders.Where(x => x.IdCustomer == idCus).ToList();
        }

    }
}
