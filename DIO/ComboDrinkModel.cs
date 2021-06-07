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


    }
}
