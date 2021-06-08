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
        public IEnumerable<Food> ListAll(int page, int pageSize)
        {
            //var listall = context.Database.SqlQuery<Food>("sp_Select_Food").ToList();
            return context.Foods.OrderBy(f => f.IdFood).ToPagedList(page, pageSize);
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

        
    }
}
