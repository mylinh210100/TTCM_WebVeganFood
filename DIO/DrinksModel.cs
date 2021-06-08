using DAO.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;

namespace DIO
{
    public class DrinksModel
    {
        private DBWebsite context = null;
        public DrinksModel()
        {
            context = new DBWebsite();
        }
        public IEnumerable<Drink> ListAll(int page, int pageSz)
        {
            //var listall = context.Database.SqlQuery<Drink>("sp_Select_DrinkAll").ToList();
            return context.Drinks.OrderBy(d => d.IdDrink).ToPagedList(page, pageSz);
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

        public Drink ViewDetail(string id)
        {
            return context.Drinks.SingleOrDefault(f => f.IdDrink == id);
        }

        public bool Update(Drink drink)
        {
            try
            {
                var d = context.Drinks.Find(drink.IdDrink);
                d.DrinkName = drink.DrinkName;
                d.DrinkPrice = drink.DrinkPrice;
                d.Drinkmaterial = drink.Drinkmaterial;
                d.ImgDrink = drink.ImgDrink;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
