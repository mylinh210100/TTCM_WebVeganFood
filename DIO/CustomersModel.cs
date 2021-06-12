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
        public IEnumerable<Customer> ListAll(string search, int page, int pageSize)
        {
            IQueryable<Customer> model = context.Customers;
            if (!string.IsNullOrEmpty(search))
            {
                model = model.Where(f => f.FullName.Contains(search) || f.Phone.ToString().Contains(search));
            }
            return model.OrderBy(f => f.IdCustomer).ToPagedList(page, pageSize);
        }
    }
}
