using DAO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO
{
    public class FoodsModel
    {
        private DBWebsite context = null;
        public FoodsModel()
        {
            context = new DBWebsite();
        }
        public List<Food> ListAll()
        {
            var listall = context.Database.SqlQuery<Food>("sp_Select_Food").ToList();
            return listall;
        }
    }
}
