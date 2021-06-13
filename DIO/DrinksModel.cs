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
        public IEnumerable<Drink> ListAll(string search, int page, int pageSz)
        {
            IQueryable<Drink> model = context.Drinks;
            if (!string.IsNullOrEmpty(search))
            {
                model = model.Where(f => f.DrinkName.Contains(search) || f.DrinkPrice.ToString().Contains(search));
            }
            return model.OrderBy(f => f.IdDrink).ToPagedList(page, pageSz);
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

        // for client
        public IEnumerable<Drink> ListDrink(int page, int pSz)
        {
            return context.Drinks.OrderBy(d => d.IdDrink).ToPagedList(page, pSz);
        }

        public Drink Top()
        {
            return context.Drinks.OrderByDescending(d => d.Quantitysold).FirstOrDefault();
        }
    }
}
