using Shop.Domain.Models.Account;
using Shop.Domain.ViewModels.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Interface
{
    public interface IUserService
    {
        #region Account
        Task<RegisterUserResult> RegisterUser(RegisterUserVm register);
        Task<LoginUserResult> LoginUser(LoginUserVm loginUser);

        Task<User> GetUserByPhone(string phonNumber);
        #endregion

    }
}
