using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgProje.Models.ViewModels
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Lütfen kullanıcı adını boş geçmeyiniz.")]
        [Display(Name = "Kullanıcı Adı ")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi boş geçmeyiniz.")]
        [DataType(DataType.Password, ErrorMessage = "Lütfen uygun formatta şifre giriniz.")]
        [Display(Name = "Şifre")]
        public string Password { get; set; }
        /// <summary>
        /// Beni hatırla...
        /// </summary>
        [Display(Name = "Beni Hatırla")]
        public bool Persistent { get; set; }
        public bool Lock { get; set; }
    }
}
