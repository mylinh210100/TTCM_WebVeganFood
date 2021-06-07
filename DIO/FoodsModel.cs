using DAO.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public int Insert(string id, string name, double price, string material, string src)
        {
            object[] parameters =
            {
                new SqlParameter("@id", id),
                new SqlParameter("@name", name),
                new SqlParameter("@price", price),
                new SqlParameter("@material", material),
                new SqlParameter("@src", src)
            };
            int add = context.Database.ExecuteSqlCommand("sp_Food_Insert @id, @name, @price, @material, @src", parameters);
            return add;
        }
    }
}
