using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace ProjectAllSample.Models
{
    public class Publishers
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "نام ناشر")]
        [Required(ErrorMessage = "وارد کردن نام ناشر الزامی است.")]
        [StringLength(150, ErrorMessage = "نام ناشر  نباید بیشتر از 30 کاراکتر باشد.")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "شهر")]
        [Required(ErrorMessage = "وارد کردن شهر الزامی است.")]
        [StringLength(20, ErrorMessage = "شهر نباید بیشتر از 10 کاراکتر باشد.")]
        public string City { get; set; } = string.Empty;

        [DisplayName("شماره موبایل")]
        [RegularExpression(@"^09\d{9}$", ErrorMessage = "شماره موبایل باید 11 رقمی و با 09 شروع شود")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int PhoneNumber { get; set; }

        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "وارد کردن {0} الزامی است.")]
        [EmailAddress(ErrorMessage = "فرمت ایمیل وارد شده صحیح نیست.")]
        public string Email { get; set; }

        [Display(Name = "وب‌سایت")]
        [Required(ErrorMessage = "لطفاً {0} را وارد کنید.")]
        [Url(ErrorMessage = "آدرس وب‌سایت معتبر نیست. مثال: https://example.com")]
        public string Website { get; set; }


    }
}
