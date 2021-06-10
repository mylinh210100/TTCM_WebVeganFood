using DAO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagedList;
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
        public IEnumerable<ComboDrinkDetail> ListAll(int page, int pSz)
        {
            //var listall = context.Database.SqlQuery<ComboDrinkDetail>("sp_View_DetailComboDrink").ToList();
            return context.ComboDrinkDetails.OrderBy(c => c.IdCombo).ToPagedList(page, pSz);
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

        public ComboDrinkDetail ViewDetail(string id)
        {
            return context.ComboDrinkDetails.SingleOrDefault(f => f.IdCombo == id);
        }

        




    }
}
