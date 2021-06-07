using DAO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO
{
    public class FoundationModel
    {
        private DBWebsite context = null;
        public FoundationModel()
        {
            context = new DBWebsite();
        }
        public List<Foundation> ListAll()
        {
            var listall = context.Database.SqlQuery<Foundation>("sp_Select_Foundation").ToList();
            return listall;
        }
    }
}
