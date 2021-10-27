using AspNetCoreAjaxModal.Models;
using AspNetCoreAjaxModalBusinessLogicLayer;
using Moq;
using System;
using Xunit;

namespace AspNetCoreAjaxModalTest
{
    public class AddOrEditTest
    {
        [Fact]
        public void TestInvalidBankId()
        {
            var transaction = new Mock<ICreateTransactionProcessor>();
            var addOrEditProcessor = new AddOrEditProcessor(transaction.Object);
            Assert.Throws<ArgumentOutOfRangeException>(() => addOrEditProcessor.AddRecord(
                new TransactionModel {
                    BankId = 0
            }));
        }

        [Fact]
        public void TestInvalidAccountNumber()
        {
            var transaction = new Mock<ICreateTransactionProcessor>();
            var addOrEditProcessor = new AddOrEditProcessor(transaction.Object);
            Assert.Throws<ArgumentOutOfRangeException>(() => addOrEditProcessor.AddRecord(
                new TransactionModel
                {
                    AccountNumber = null
                }));
        }

        [Fact]
        public void TestInvalidBeneficiaryName()
        {
            var transaction = new Mock<ICreateTransactionProcessor>();
            var addOrEditProcessor = new AddOrEditProcessor(transaction.Object);
            Assert.Throws<ArgumentOutOfRangeException>(() => addOrEditProcessor.AddRecord(
                new TransactionModel
                {
                    BeneficiaryName = ""//String.Empty
                }));
        }

        [Fact]
        public void TestInvalidSwiftCode()
        {
            var transaction = new Mock<ICreateTransactionProcessor>();
            var addOrEditProcessor = new AddOrEditProcessor(transaction.Object);
            Assert.Throws<ArgumentOutOfRangeException>(() => addOrEditProcessor.AddRecord(
                new TransactionModel
                {
                    SwiftCode = "ALJDLJ!@#ghhd1569" // total length > 11
                }));
        }

        [Fact]
        public void TestInvalidTransactionDateTime()
        {
            var transaction = new Mock<ICreateTransactionProcessor>();
            var addOrEditProcessor = new AddOrEditProcessor(transaction.Object);
            Assert.Throws<ArgumentOutOfRangeException>(() => addOrEditProcessor.AddRecord(
                new TransactionModel
                {
                    TransactionDateTime = DateTime.Now.AddDays(2)
                }));
        }

        [Fact]
        public void TestStaticValidArguments()
        {
            var transaction = new Mock<ICreateTransactionProcessor>();
            var addOrEditProcessor = new AddOrEditProcessor(transaction.Object);
            Assert.True(addOrEditProcessor.AddRecord(
                new TransactionModel
                {
                    TransactionDateTime = DateTime.Today.AddDays(-2),
                    BankId = 2,
                    AccountNumber = "FT1223434",
                    BeneficiaryName = "Frank Thomson",
                    SwiftCode = "RT258456QA"
                }));
        }

        [Fact]
        public void TestMockValidArguments()
        {
            var transaction = new Mock<ICreateTransactionProcessor>();
           
            var transactionModel = new TransactionModel
            {
                TransactionDateTime = DateTime.Today.AddDays(-2),
                BankId = 2,
                AccountNumber = "FT1223434",
                BeneficiaryName = "Frank Thomson",
                SwiftCode = "RT258456QA"
            };
            //transaction.Setup(p => p.Create(It.IsAny<TransactionModel>())).Returns(true); // var 1
            transaction.Setup(p => p.Create(transactionModel)).Returns(true);
            var addOrEditProcessor = new AddOrEditProcessor(transaction.Object);
            
            Assert.True(addOrEditProcessor.AddRecord(
                transactionModel
            ));
            
        }

    }
}
