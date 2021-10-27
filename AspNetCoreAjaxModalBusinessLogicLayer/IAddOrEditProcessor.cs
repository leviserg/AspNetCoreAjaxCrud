using AspNetCoreAjaxModal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCoreAjaxModalBusinessLogicLayer
{
    interface IAddOrEditProcessor
    {
        bool AddRecord(TransactionModel transactionModel);
    }
}
