using DAO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public List<Customer> ListAll()
        {
            var listall = context.Database.SqlQuery<Customer>("sp_View_Customer").ToList();
            return listall;
        }
    }
}
