using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Interface
{
    internal interface IPasswordHelper
    {
        string EncodePasswordMdS(string password);
    }
}
