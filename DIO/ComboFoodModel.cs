using DAO.Model;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO
{
    public class ComboFoodModel
    {
        private DBWebsite context = null;

        public ComboFoodModel()
        {
            context = new DBWebsite();
        }
        public IEnumerable<ComboFoodDetail> ListAll(int page, int pSz)
        {
            //var listall = context.Database.SqlQuery<ComboFoodDetail>("sp_View_DetailComboFood").ToList();
            return context.ComboFoodDetails.OrderBy(f => f.Id).ToPagedList(page, pSz);
        }

        public string Insert(ComboFoodDetail detail)
        {
            context.ComboFoodDetails.Add(detail);
            context.SaveChanges();
            return detail.IdFood;
        }

        public List<Food> ListID()
        {
            return context.Foods.Where(f => f.Status == 1).ToList();
        }

        public ComboFoodDetail ViewDetail(int id)
        {
            return context.ComboFoodDetails.SingleOrDefault(f => f.Id == id);
        }

        public bool Update(ComboFoodDetail food)
        {
            try
            {
                var f = context.ComboFoodDetails.Find(food.Id);
                f.Price = food.Price;
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
