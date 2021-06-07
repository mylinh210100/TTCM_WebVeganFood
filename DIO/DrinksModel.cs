using DAO.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO
{
    public class DrinksModel
    {
        private DBWebsite context = null;
        public DrinksModel()
        {
            context = new DBWebsite();
        }
        public List<Drink> ListAll()
        {
            var listall = context.Database.SqlQuery<Drink>("sp_Select_DrinkAll").ToList();
            return listall;
        }

        public int InsertDrink(string id, string name, double price, string material, string src)
        {
            object[] parameters =
            {
                new SqlParameter("@id", id),
                new SqlParameter("@name", name),
                new SqlParameter("@price", price),
                new SqlParameter("@material", material),
                new SqlParameter("@src", src)
            };
            int rs = context.Database.ExecuteSqlCommand("sp_Drink_Insert @id, @name, @price, @material, @src", parameters);
            return rs;
        }
    }
}
