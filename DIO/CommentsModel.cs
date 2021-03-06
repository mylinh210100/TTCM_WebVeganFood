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
        public IEnumerable<Comment> ListAll(string search, int? page)
        {

            int recordsPage = 5;
            if (!page.HasValue)
            {
                page = 1;
            }
            IQueryable<Comment> drink = context.Comments;
            try
            {
                if (!string.IsNullOrEmpty(search))
                {
                    drink = drink.Where(f => f.IdAcc.ToString().Contains(search) || f.IdProduct.Contains(search) || f.Comments.Contains(search));

                }
            }
            catch (Exception ex)
            {
            }
            return drink.OrderBy(f => f.IdComment).ToPagedList(page.Value, recordsPage);
        }

        public IEnumerable<Comment> ViewComment(string id)
        {
            return context.Comments.Where(c => c.IdProduct == id).ToList();
        }


        public string InsertCmt(Comment comment)
        {
            context.Comments.Add(comment);
            context.SaveChanges();
            return comment.Comments;
        }
    }
}
