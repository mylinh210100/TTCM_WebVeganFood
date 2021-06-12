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
        public IEnumerable<Comment> ListAll(string search, int page, int pageSize)
        {
            IQueryable<Comment> model = context.Comments;
            if (!string.IsNullOrEmpty(search))
            {
                model = model.Where(f => f.Comments.Contains(search) || f.IdProduct.Contains(search) ||
                                    f.IdAcc.ToString().Contains(search));
            }
            return model.OrderBy(f => f.IdProduct).ToPagedList(page, pageSize);
        }
    }
}
