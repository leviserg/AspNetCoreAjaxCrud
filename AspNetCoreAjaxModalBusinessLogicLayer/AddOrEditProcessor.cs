using AspNetCoreAjaxModal.Models;
using System;

namespace AspNetCoreAjaxModalBusinessLogicLayer
{
    public class AddOrEditProcessor : IAddOrEditProcessor
    {
        private readonly ICreateTransactionProcessor _createTransactionProcessor;

        public AddOrEditProcessor(ICreateTransactionProcessor createTransactionProcessor)
        {
            this._createTransactionProcessor = createTransactionProcessor;
        }

        public bool AddRecord(TransactionModel transactionModel)
        {
            if(transactionModel.BankId <= 0)
            {
                throw new ArgumentOutOfRangeException("BankId can not be less than 1");
            }
            if (transactionModel.BeneficiaryName.Length == 0 || transactionModel.BeneficiaryName == null || transactionModel.BeneficiaryName.Length > 100)
            {
                throw new ArgumentOutOfRangeException("BeneficiaryName should be specified with length <= 100 chars");
            }
            if (transactionModel.SwiftCode.Length == 0 || transactionModel.SwiftCode == null || transactionModel.SwiftCode.Length > 11)
            {
                throw new ArgumentOutOfRangeException("SwiftCode should be specified with length <= 11 chars");
            }
            if (transactionModel.AccountNumber.Length == 0 || transactionModel.AccountNumber == null || transactionModel.AccountNumber.Length > 12)
            {
                throw new ArgumentOutOfRangeException("SwiftCode should be specified with length <= 12 chars");
            }
            if (transactionModel.TransactionDateTime > DateTime.Today)
            {
                throw new ArgumentOutOfRangeException("Transaction Date is greater than today");
            }

            return _createTransactionProcessor.Create(transactionModel); // returns true if OK otherwise false

        }
    }
}
