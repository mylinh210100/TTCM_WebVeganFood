using DAO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO
{
    public class ComboDrinkModel
    {
        private DBWebsite context = null;

        public ComboDrinkModel()
        {
           context = new DBWebsite();
        }
        public List<ComboDrinkDetail> ListAll()
        {
            var listall = context.Database.SqlQuery<ComboDrinkDetail>("sp_View_DetailComboDrink").ToList();
            return listall;
        }

        public string Insert(ComboDrinkDetail detail)
        {
            context.ComboDrinkDetails.Add(detail);
            context.SaveChanges();
            return detail.IdDrink;
        }

        public List<Drink> ListID()
        {
            return context.Drinks.Where(d => d.Status == 1).ToList();
        }

        //public ComboDrinkDetail ViewDetail(string idc)
        //{
        //    return context.ComboDrinkDetails.SingleOrDefault(f => f.IdCombo == idc);
        //}

        //public bool Update(ComboDrinkDetail drink)
        //{
        //    try
        //    {
        //        var d = context.ComboDrinkDetails.Find(drink.IdDrink);
        //        d.Price = drink.Price;

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
