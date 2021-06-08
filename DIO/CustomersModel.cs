using DAO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagedList;
using System.Threading.Tasks;

namespace DIO
{
    public class CustomersModel
    {
        private DBWebsite context = null;
        public CustomersModel()
        {
            context = new DBWebsite();
        }
        public IEnumerable<Customer> ListAll(int page, int pageSz)
        {
            // var listall = context.Database.SqlQuery<Customer>("sp_View_Customer").ToList();
            return context.Customers.OrderBy(c => c.IdCustomer).ToPagedList(page, pageSz);
        }
    }
}
