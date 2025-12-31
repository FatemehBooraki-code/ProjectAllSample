using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjectAllSample.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Display(Name = "عنوان کتاب")]
        [Required(ErrorMessage = "وارد کردن عنوان کتاب الزامی است.")]
        [StringLength(150, ErrorMessage = "عنوان کتاب نباید بیشتر از 150 کاراکتر باشد.")]
        public string Title { get; set; } = string.Empty;

        [Display(Name = "شابک")]
        [Required(ErrorMessage = "وارد کردن شابک الزامی است.")]
        [StringLength(20, ErrorMessage = "شابک نباید بیشتر از 20 کاراکتر باشد.")]
        public string ISBN { get; set; } = string.Empty;

        [Display(Name = "سال انتشار")]
        [Required(ErrorMessage = "وارد کردن سال انتشار الزامی است.")]
        [Range(1300, 1405, ErrorMessage = "سال انتشار باید بین 1300 تا 1405 باشد.")]
        public int PublishYear { get; set; }

        [Display(Name = "دسته‌بندی")]
        [Required(ErrorMessage = "وارد کردن دسته‌بندی الزامی است.")]
        [StringLength(50, ErrorMessage = "دسته‌بندی نباید بیشتر از 50 کاراکتر باشد.")]
        public string Category { get; set; } = string.Empty;

        [Display(Name = "تعداد موجود")]
        [Required(ErrorMessage = "وارد کردن تعداد موجود الزامی است.")]
        [Range(0, 10000, ErrorMessage = "تعداد موجود باید بین ۰ تا ۱۰۰۰۰ باشد.")]
        public int AvailableCount { get; set; }


        #region Relations
        public virtual ICollection<Loans> Loans { get; set; }
        #endregion
    }
}
