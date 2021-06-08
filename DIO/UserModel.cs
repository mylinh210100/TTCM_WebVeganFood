﻿using DAO.Model;
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

        public long InsertAcc(Account acc)
        {
            context.Accounts.Add(acc);
            context.SaveChanges();
            return acc.IdAcc;
        }

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
        public IEnumerable<Account> ListAccPaging(int page, int pageSize)
        {
            //var listAcc = context.Database.SqlQuery<Account>("sp_Select_Account").ToList();
            return context.Accounts.OrderBy(a=>a.IdAcc).ToPagedList(page, pageSize);
        }
    }
}