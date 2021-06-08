﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace webVegankitchen.Common
{
    public static class Encryptor
    {
        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            //compute hash from the bytes of text
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            
            //get hash result after compute it
            byte[] rs = md5.Hash;

            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < rs.Length; i++)
            {
                //change it into 2 hexademical digits
                //for each byte

                stringBuilder.Append(rs[i].ToString("x2"));
            }
            return stringBuilder.ToString();
        }
    }
}