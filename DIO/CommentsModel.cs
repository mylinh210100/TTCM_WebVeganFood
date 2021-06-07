﻿using DAO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public List<Comment> ListAll()
        {
            var listall = context.Database.SqlQuery<Comment>("sp_View_Cmt").ToList();
            return listall;
        }
    }
}
