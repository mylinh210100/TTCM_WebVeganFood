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
        public IEnumerable<Customer> ListAll(string search, int? page)
        {

            int recordsPage = 5;
            if (!page.HasValue)
            {
                page = 1;
            }
            IQueryable<Customer> drink = context.Customers;
            try
            {
                if (!string.IsNullOrEmpty(search))
                {
                    drink = drink.Where(f => f.IdAcc.ToString().Contains(search) || f.FullName.Contains(search)
                                    || f.Phone.Contains(search) || f.Address.Contains(search));

                }
            }
            catch (Exception ex)
            {
            }
            return drink.OrderBy(f => f.IdCustomer).ToPagedList(page.Value, recordsPage);
        }

        public long Insert(Customer cus)
        {
            context.Customers.Add(cus);
            context.SaveChanges();
            return cus.IdCustomer;

        }

        public Customer ViewDetail(int id)
        {
            return context.Customers.SingleOrDefault(c => c.IdAcc == id);
        }

        public Customer EditDetail(int id)
        {
            return context.Customers.SingleOrDefault(c => c.IdCustomer == id);
        }

        public bool Update(Customer customer)
        {
            try
            {
                var c = context.Customers.Find(customer.IdCustomer);
                c.FullName = customer.FullName;
                c.Phone = customer.Phone;
                c.Address = customer.Address;
                c.Email = customer.Email;
                context.SaveChanges();

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

    }
}
