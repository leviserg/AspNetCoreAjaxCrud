using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreAjaxModal.Models
{
    public interface ICreateTransactionProcessor
    {
        bool Create(TransactionModel transactionModel);
    }
}
