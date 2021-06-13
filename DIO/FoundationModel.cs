using DAO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagedList;
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
        public IEnumerable<Foundation> ListAll(int page, int pageSz)
        {
            //var listall = context.Database.SqlQuery<Foundation>("sp_Select_Foundation").ToList();
            return context.Foundations.OrderBy(f => f.IdFound).ToPagedList(page, pageSz);
        }

        public List<Foundation> List()
        {
            return context.Foundations.ToList();
        }
    }
}
