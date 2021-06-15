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
    public class FoodsModel
    {
        private DBWebsite context = null;
        public FoodsModel()
        {
            context = new DBWebsite();
        }

        // for admin        
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

        public Food ViewDetail(string id)
        {
            return context.Foods.SingleOrDefault(f => f.IdFood == id);
        }

        public bool Update(Food food)
        {
            try
            {
                var f = context.Foods.Find(food.IdFood);
                f.FoodName = food.FoodName;
                f.FoodPrice = food.FoodPrice;
                f.Foodmaterial = food.Foodmaterial;
                f.ImgFood = food.ImgFood;
                context.SaveChanges();
            }
            catch(Exception e)
            {
                return false;
            }
            return true;
        }

        // for Client
        public IEnumerable<Food> ListFood(string search, int? page)
        {
            int recordsPage = 5;
            if (!page.HasValue)
            {
                page = 1;
            }
            IQueryable<Food> food = context.Foods;
            try
            {
                if (!string.IsNullOrEmpty(search))
                {
                    food = food.Where(f => f.FoodName.Contains(search) || f.FoodPrice.ToString().Contains(search) || f.Quantitysold.ToString().Contains(search));

                }
            }
            catch (Exception ex)
            {
            }
            return food.OrderByDescending(f=>f.Quantitysold).ToPagedList(page.Value, recordsPage);
            
        }

        public Food Top()
        {
            return context.Foods.OrderByDescending(f => f.Quantitysold).FirstOrDefault();
        }

        public IEnumerable<Food> ListOther(string id, int p, int pSz)
        {
            return context.Foods.Where(f => f.IdFood != id).OrderBy(f => f.IdFood).ToPagedList(p, pSz);
        }
    }
}
