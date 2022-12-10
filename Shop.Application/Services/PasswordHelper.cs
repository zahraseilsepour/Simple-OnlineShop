using Shop.Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Services
{
    public class PasswordHelper : IPasswordHelper
    {
        public string EncodePasswordMdS(string password)
        {
          Byte  [] orgPass;
          Byte [] encodePass;
            MD5 md5;
            md5 = new MD5CryptoServiceProvider();
            orgPass = ASCIIEncoding.Default.GetBytes(password);
            encodePass = md5.ComputeHash(orgPass);
            return BitConverter.ToString(encodePass);
            

        }
    }
}
