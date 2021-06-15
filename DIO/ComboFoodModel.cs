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
        public IEnumerable<ComboFoodDetail> ListAll(string search, int? page)
        {
            int recordsPage = 5;
            if (!page.HasValue)
            {
                page = 1;
            }
            IQueryable<ComboFoodDetail> drink = context.ComboFoodDetails;
            try
            {
                if (!string.IsNullOrEmpty(search))
                {
                    drink = drink.Where(f => f.IdCombo.Contains(search) || f.IdFood.Contains(search));

                }
            }
            catch (Exception ex)
            {
            }
            return drink.OrderBy(f => f.IdCombo).ToPagedList(page.Value, recordsPage);
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
