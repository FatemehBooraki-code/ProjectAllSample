using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjectAllSample.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("نام و نام خانوادگی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string FullName { get; set; }

        [DisplayName("سال تولد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Range(1300, 1500, ErrorMessage = "{0} باید بین {1} تا {2} باشد")]
        public int BirthYear { get; set; }

        [DisplayName("کشور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string Country { get; set; }

        [DisplayName("ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [EmailAddress(ErrorMessage = "فرمت ایمیل صحیح نیست")]
        [MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string Email { get; set; }

        [DisplayName("بیوگرافی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(500, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string Bio { get; set; }
    }
}
