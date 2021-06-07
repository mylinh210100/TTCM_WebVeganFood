using DAO.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DIO
{
    public class Account
    {
        private DBWebsite context = null;

        public Account()
        {
            context = new DBWebsite();
        }

        public bool Login(string userName, string pass)
        {
            object[] sqlParams =
            {
            new SqlParameter("@UserName", userName),
            new SqlParameter("@PassWord", pass)
            };
            var result = context.Database.SqlQuery<bool>("sp_Check_Login @UserName, @PassWord", sqlParams).SingleOrDefault();
            return result;
        }
    }
}
