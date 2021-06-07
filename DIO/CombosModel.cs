using DAO.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO
{
    public class CombosModel
    {
        private DBWebsite context = null;
        public CombosModel()
        {
            context = new DBWebsite();
        }
        public List<Combo> ListAll()
        {
            var listall = context.Database.SqlQuery<Combo>("sp_Select_ComboAll").ToList();
            return listall;
        }

        public int Insert(string id, string name, double price, int numoffood, int numofdrink, int numofperson, string src)
        {
            object[] parameters =
            {
                new SqlParameter("@id", id),
                new SqlParameter("@name", name),
                new SqlParameter("@price", price),
                new SqlParameter("@numoffood", numoffood),
                new SqlParameter("@numofdrink", numofdrink),
                new SqlParameter("@numofperson", numofperson),
                new SqlParameter("@src", src)
            };
            int add = context.Database.ExecuteSqlCommand("sp_Combo_Insert @id, @name, @price, @numoffood, @numofdrink, @numofperson, @src", parameters);
            return add;
        }
    }
}
