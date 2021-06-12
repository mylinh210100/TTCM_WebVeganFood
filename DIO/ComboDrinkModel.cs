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
        public IEnumerable<ComboDrinkDetail> ListAll(string search, int page, int pageSize)
        {
            IQueryable<ComboDrinkDetail> model = context.ComboDrinkDetails;
            if (!string.IsNullOrEmpty(search))
            {
                model = model.Where(f => f.IdCombo.Contains(search) || f.IdDrink.Contains(search));
            }
            return model.OrderBy(f => f.Id).ToPagedList(page, pageSize);
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
