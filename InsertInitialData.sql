USE [AspNetDb]
GO

INSERT INTO [dbo].[Banks] VALUES ('Credit Agricole');
INSERT INTO [dbo].[Banks] VALUES ('Morgan Stanley');
INSERT INTO [dbo].[Banks] VALUES ('Bank Of America');
GO

INSERT INTO [dbo].[Transactions] VALUES ('JA3246021','Jane Air',1,'CTBAAU2S',1232,GETDATE())
INSERT INTO [dbo].[Transactions] VALUES ('MH7801453','Mike Hummer',2,'J25AJNS7',314,GETDATE())
GO

SELECT a.TransactionId,
	a.AccountNumber,
	a.BeneficiaryName,
	b.[BankName],
	a.SwiftCode,
	a.Amount,
	a.TransactionDateTime
FROM [dbo].[Transactions] a
INNER JOIN [dbo].[Banks] b ON a.BankId = b.Id
