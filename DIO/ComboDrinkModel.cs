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
        public IEnumerable<ComboDrinkDetail> ListAll(string search, int? page)
        {
            int recordsPage = 5;
            if (!page.HasValue)
            {
                page = 1;
            }
            IQueryable<ComboDrinkDetail> drink = context.ComboDrinkDetails;
            try
            {
                if (!string.IsNullOrEmpty(search))
                {
                    drink = drink.Where(f => f.IdDrink.Contains(search) || f.IdCombo.Contains(search));

                }
            }
            catch (Exception ex)
            {
            }
            return drink.OrderBy(f => f.IdCombo).ToPagedList(page.Value, recordsPage);
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
