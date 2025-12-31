using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Net;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectAllSample.Models
{
    public class Loans
    {

        [Key]
        public int Id { get; set; }


        [DisplayName("تاریخ امانت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public DateTime LoanDate { get; set; }

        [DisplayName("تاریخ سررسید")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public DateTime ArrivedDate { get; set; }

        [DisplayName("تاریخ بازگشت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public DateTime ComebackDate { get; set; }


        #region Relations
        [ForeignKey("MemberId")]
        [DisplayName(" شناسه عضو")]
        public virtual Member Member { get; set; }
        #endregion

        #region Relations
        [ForeignKey("BookId")]
        [DisplayName(" شناسه کتاب")]
        public virtual Book Book { get; set; }
        #endregion

    }
}
