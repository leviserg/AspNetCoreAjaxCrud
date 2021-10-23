using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreAjaxModal.Models
{
    public class TransactionViewModel
    {
        public TransactionModel Transaction { get; set; }
        public int? SelectedBankId { get; set; }
        public List<BankModel> Banks { get; set; }

        public TransactionViewModel(TransactionModel transactionModel)
        {
            this.Transaction = transactionModel;
        }

    }
}
