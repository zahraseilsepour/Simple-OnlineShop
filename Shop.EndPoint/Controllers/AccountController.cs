using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.Interface;
using Shop.Domain.ViewModels.Account;
using System.Security.Claims;

namespace Shop.EndPoint.Controllers
{
    public class AccountController : SiteBaseController
    {
        #region Constractor
        private readonly IUserService _userService;
        public AccountController(IUserService userService)
        {
           _userService = userService;
        }
        #endregion
        #region Register
        [HttpGet("register")]
        public IActionResult Register()
        {
            return View(); 
        }
        [HttpPost,ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterUserVm register)
        {
            if (ModelState.IsValid)
            {
                var result=await _userService.RegisterUser(register);
                switch (result)
                {
                    case RegisterUserResult.MobileExists:
                        break;
                    case RegisterUserResult.Success:
                        break;
                }
            }
            return View(register);

        }

        #endregion
        #region Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost("Login"),ValidateAntiForgeryToken]
        private async Task<IActionResult> Login(LoginUserVm login)
        {
            if (ModelState.IsValid)
            {
                var result=await _userService.LoginUser(login);
                switch (result)
                {
                   
                    case LoginUserResult.NotFound:
                        break;
                    case LoginUserResult.NotActive:
                        break;
                    case LoginUserResult.InBlocked:
                        break;
                    case LoginUserResult.Success:
                        var user=await _userService.GetUserByPhone(login.PhoneNumber);
                        var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name,login.PhoneNumber),
                            new Claim(ClaimTypes.NameIdentifier,user.Id.ToString())
                        };
                        var identity=new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
                        var principle=new ClaimsPrincipal(identity);
                        var properties = new AuthenticationProperties
                        {
                            IsPersistent = login.Remember
                        };
                        await HttpContext.SignInAsync(principle, properties);
                        return Redirect("/");
                }
            }
            return View(login);
        }
        #endregion
        public IActionResult Index()
        {
            return View();
        }
    }
}
