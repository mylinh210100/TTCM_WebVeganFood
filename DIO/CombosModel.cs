using DAO.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using PagedList;
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
        public IEnumerable<Combo> ListAll(string search, int page, int pSz)
        {
            IQueryable<Combo> model = context.Comboes;
            if (!string.IsNullOrEmpty(search))
            {
                model = model.Where(f => f.ComboName.Contains(search) || f.ComboPrice.ToString().Contains(search));
            }
            return model.OrderBy(f => f.IdCombo).ToPagedList(page, pSz);
        }

        public int Insert(string id, string name, int numofperson, string src)
        {
            object[] parameters =
            {
                new SqlParameter("@id", id),
                new SqlParameter("@name", name),
                new SqlParameter("@numofperson", numofperson),
                new SqlParameter("@src", src)
            };
            int add = context.Database.ExecuteSqlCommand("sp_Combo_Insert @id, @name, @numofperson, @src", parameters);
            return add;
        }

        public Combo ViewDetail(string id)
        {
            return context.Comboes.SingleOrDefault(f => f.IdCombo == id);
        }

        public bool Update(Combo combo)
        {
            try
            {
                var c = context.Comboes.Find(combo.IdCombo);
                c.ComboName = combo.ComboName;
                c.NumberOfPerson = combo.NumberOfPerson;
                c.ImgCombo = combo.ImgCombo;

                context.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        
    }
}
