using DAO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;

namespace DIO
{
    public class UserModel
    {
        DBWebsite context = null;

        public UserModel()
        {
            context = new DBWebsite();
        }
        public Account GetByName(string userName)
        {
            return context.Accounts.SingleOrDefault(a => a.Username == userName);
        }

        
        // for admin
        public int Login(string userName, string pass)
        {
            var rs = context.Accounts.SingleOrDefault(a => a.Username == userName);
            if(rs == null)
            {
                return 0; //not exist
            }
            else
            {
                if (rs.PassWo == pass)
                {
                    return 1; //true
                }
                else
                    return -1; //false
            }
        }

        //danh sach theo phan trang
        public IEnumerable<Account> ListAccPaging(string search, int? page)
        {
            int recordsPage = 5;
            if (!page.HasValue)
            {
                page = 1;
            }
            IQueryable<Account> drink = context.Accounts;
            try
            {
                if (!string.IsNullOrEmpty(search))
                {
                    drink = drink.Where(f => f.IdAcc.ToString().Contains(search) || f.Username.Contains(search));

                }
            }
            catch (Exception ex)
            {
            }
            return drink.OrderBy(f => f.IdAcc).ToPagedList(page.Value, recordsPage);
        }

        // sign in for customer
        public int Signin(string username, string pass)
        {
            var rs = context.Accounts.SingleOrDefault(a => a.Username == username);
            if (rs == null)
            {
                return 0;
            }
            else
            {
                if (rs.PassWo == pass)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }

        //public int GetUsername(string name)
        //{
        //    return
        //}

        public long InsertAcc(Account acc)
        {
            context.Accounts.Add(acc);
            context.SaveChanges();
            return acc.IdAcc;
        }

    }
}
