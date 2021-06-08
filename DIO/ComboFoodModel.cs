using DAO.Model;
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
        public List<ComboFoodDetail> ListAll()
        {
            var listall = context.Database.SqlQuery<ComboFoodDetail>("sp_View_DetailComboFood").ToList();
            return listall;
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

        //public ComboFoodDetail ViewDetail(string idc)
        //{
        //    return context.ComboFoodDetails.SingleOrDefault(f => f.IdCombo == idc);
        //}

        //public bool Update(ComboFoodDetail food)
        //{
        //    try
        //    {
        //        var f = context.ComboFoodDetails.Find(food.IdFood);
        //        f.Price = food.Price;

        //        context.SaveChanges();
        //    }
        //    catch (Exception e)
        //    {
        //        return false;
        //    }
        //    return true;
        //}
    
    
    
    }
}
