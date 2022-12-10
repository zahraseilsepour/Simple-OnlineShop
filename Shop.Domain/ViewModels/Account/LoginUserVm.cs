using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.ViewModels.Account
{
    public class LoginUserVm
    {
        [Display(Name = "شماره همراه")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(255, ErrorMessage = "{نمیتواند بیشتر از {1} کاراکتر باشد{0")]
        public string PhoneNumber { get; set; }

        [Display(Name = "گذرواژه")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(255, ErrorMessage = "{نمیتواند بیشتر از {1} کاراکتر باشد{0")]
        public string Password { get; set; }
        [Display(Name = "مرا به خاطر بسپار")]
        public bool Remember { get; set; }
    }
    public enum LoginUserResult
    {
        NotFound,
        NotActive,
        Success,
        InBlocked
    }
}
