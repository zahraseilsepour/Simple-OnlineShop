using Shop.Application.Interface;
using Shop.Domain.Interface;
using Shop.Domain.Models.Account;
using Shop.Domain.ViewModels.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Services
{
    public class UserService:IUserService
    {
        #region Constractor
        private readonly IUserRepository _userRepository;
        private readonly IPasswordHelper _passwordHelper;
        public UserService(IUserRepository userRepository ,IPasswordHelper passwordHelper)
        {
            _userRepository= userRepository;
            _passwordHelper= passwordHelper;
        }

        public async Task<User> GetUserByPhone(string phonNumber)
        {
           return await _userRepository.GetUserByPhone(phonNumber);
        }
        #endregion


        public async Task<LoginUserResult> LoginUser(LoginUserVm loginUser)
        {
           var user=await _userRepository.GetUserByPhone(loginUser.PhoneNumber);
            if (user == null) return LoginUserResult.NotFound;
            if (user.IsBlocked) return LoginUserResult.NotActive;
            if (user.MobileActive) return LoginUserResult.NotFound;
            if (user.Password!=_passwordHelper.EncodePasswordMdS(loginUser.Password)) return LoginUserResult.NotActive;
            return LoginUserResult.Success;
        }

        #region Account
        public async Task<RegisterUserResult> RegisterUser(RegisterUserVm register)
        {
          if(!await _userRepository.IsExistPhonNumber(register.PhoneNumber))
            {
                var user = new User
                {
                    FirstName = register.FirstName,
                    LastName = register.LastName,
                    Password=_passwordHelper.EncodePasswordMdS(register.Password),
                    PhoneNumber = register.PhoneNumber,
                    Avatar = "/image/defult.png",
                    MobileActive = false,
                    MobileActiveCode = new Random().Next(100000, 99999).ToString(),


                };
                await _userRepository.CreateUser(user);
                return RegisterUserResult.Success;
            }
            return RegisterUserResult.MobileExists;
        }
        #endregion
    }
}
