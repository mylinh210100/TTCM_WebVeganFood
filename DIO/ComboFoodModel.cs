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
    }
}
