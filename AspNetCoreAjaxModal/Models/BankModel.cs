using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreAjaxModal.Models
{
    public class BankModel
    {
        [Display(Name = "Bank")]
        public int Id { get; set; }

        [Display(Name = "Bank Name")]
        public string BankName { get; set; }

        public virtual List<TransactionModel> Transactions { get; set; }

    }
}
