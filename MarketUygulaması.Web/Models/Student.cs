using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarketUygulaması.Web.Models
{
    public class Student
    {
        [Required(ErrorMessage="İsminizi giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Email adresi giriniz")]
        [EmailAddress(ErrorMessage ="Lütfen mail adresinizi doğru şekilde giriniz")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Telefon numarası giriniz")]
        public string Phone { get; set; }
        [Required(ErrorMessage ="Kursa kaılıp katılmayacağınıza karar veriniz")]
        public bool? WillAttend { get; set; }
    }
}
