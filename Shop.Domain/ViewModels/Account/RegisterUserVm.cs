using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.ViewModels.Account
{
    public class RegisterUserVm
    {
        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(255, ErrorMessage = "{نمیتواند بیشتر از {1} کاراکتر باشد{0")]
        public string FirstName { get; set; }
        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(255, ErrorMessage = "{نمیتواند بیشتر از {1} کاراکتر باشد{0")]
        public string LastName { get; set; }
        [Display(Name = "شماره همراه")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(255, ErrorMessage = "{نمیتواند بیشتر از {1} کاراکتر باشد{0")]
        public string PhoneNumber { get; set; }
        [Display(Name = "گذرواژه")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(255, ErrorMessage = "{نمیتواند بیشتر از {1} کاراکتر باشد{0")]
        public string Password { get; set; }

        [Display(Name = "تکرارگذرواژه")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [Compare("Password", ErrorMessage = "کلمه عبور همخوانی ندارد")]
        public string ConfirmPassword { get; set; }
    }
    public enum RegisterUserResult
    {
        Success,
        MobileExists
    }
}
