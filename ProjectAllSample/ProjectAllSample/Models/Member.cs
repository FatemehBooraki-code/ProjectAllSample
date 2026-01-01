using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjectAllSample.Models
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }

        [DisplayName("نام و نام خانوادگی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از {1} باشد")]
        public string FullName { get; set; }

        [DisplayName("کدملی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "کد ملی باید 10 رقمی باشد")]
        public string NationalCode { get; set; }

        [DisplayName("شماره موبایل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [RegularExpression(@"^09\d{9}$", ErrorMessage = "شماره موبایل باید 11 رقمی و با 09 شروع شود")]
        public string PhoneNumber { get; set; }

        [DisplayName("آدرس")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(300, ErrorMessage = "{0} نمی تواند بیشتر از {1} باشد")]
        public string Address { get; set; }


        [DisplayName("تاریخ عضویت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public DateTime RegisterDate { get; set; }


        #region Relations
        public virtual ICollection<Loans> Loans { get; set; }
        #endregion
    }
}
