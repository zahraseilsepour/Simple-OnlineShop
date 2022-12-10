using Shop.Domain.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Interface
{
    public interface IUserRepository
    {
        #region Account
        Task<bool>IsExistPhonNumber(string phonNumber);
        Task CreateUser(User user);
        Task<User> GetUserByPhone(string phonNumber);

        #endregion
    }
}
