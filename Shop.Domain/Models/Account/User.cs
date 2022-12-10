using Shop.Domain.Models.BaseEntites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Models.Account
{
    public class User:BaseEntity
    {
        [Display(Name="نام")]
        [Required(ErrorMessage ="لطفا {0} را وارد نمایید")]
        [MaxLength(255,ErrorMessage ="{نمیتواند بیشتر از {1} کاراکتر باشد{0")]
        public string FirstName { get; set; }
        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(255, ErrorMessage = "{نمیتواند بیشتر از {1} کاراکتر باشد{0")]
        public string LastName { get; set; }
        [Display(Name = "شماره همراه")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(255, ErrorMessage = "{نمیتواند بیشتر از {1} کاراکتر باشد{0")]
        public string PhoneNumber { get; set; }
        [Display(Name = "آواتار")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(255, ErrorMessage = "{نمیتواند بیشتر از {1} کاراکتر باشد{0")]
        public string Avatar { get; set; }
        [Display(Name = "مسدود شده/مسدود نشده")]
        public bool IsBlocked { get; set; }
        [Display(Name = "گذرواژه")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(255, ErrorMessage = "{نمیتواند بیشتر از {1} کاراکتر باشد{0")]
        public string Password { get; set; }
        [Display(Name = "جنسیت")]
        public UserGender Gender { get; set; }
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(50, ErrorMessage = "{نمیتواند بیشتر از {1} کاراکتر باشد{0")]
        [Display(Name = "کد احراز هویت")]
        public string MobileActiveCode { get; set; }
        [Display(Name = "تایید شده/تایید نشده")]
        public bool MobileActive { get; set; }
    }

    public enum UserGender
    {
        [Display(Name = "آقا")]
        Mail,
        [Display(Name = "خانم")]
        FeMil,
     
    }
}
