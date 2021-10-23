using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreAjaxModal.Models
{
    public class TransactionModel
    {
        [Key]
        public int TransactionId { get; set; }

        [MaxLength(12)]
        [Required(ErrorMessage = "This field is required")]
        [Column(TypeName = "nvarchar(12)")]
        [Display(Name = "Account Number")]
        public string AccountNumber { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "This field is required")]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Beneficiary Name")]
        public string BeneficiaryName { get; set; }

        public int BankId { get; set; }
        //public int? BankId { get; set; } - optional parameter with Null values, used with Update-Database console command

        [MaxLength(11)]
        [Required(ErrorMessage = "This field is required")]
        [Column(TypeName = "nvarchar(11)")]
        [Display(Name = "SWIFT Code")]
        public string SwiftCode { get; set; }
        public int Amount { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        [Display(Name = "Transaction Date")]
        public DateTime TransactionDateTime { get; set; } = DateTime.Now;

        [Display(Name = "Bank")]
        public virtual BankModel Bank { get; set; }

    }
}
