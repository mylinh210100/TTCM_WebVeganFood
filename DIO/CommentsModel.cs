using DAO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagedList;
using System.Threading.Tasks;

namespace DIO
{
    public class CommentsModel
    {
        private DBWebsite context = null;
        public CommentsModel()
        {
            context = new DBWebsite();
        }
        public IEnumerable<Comment> ListAll(int page, int pSz)
        {
            //var listall = context.Database.SqlQuery<Comment>("sp_View_Cmt").ToList();
            return context.Comments.OrderBy(c => c.IdAcc).ToPagedList(page, pSz);
        }
    }
}
