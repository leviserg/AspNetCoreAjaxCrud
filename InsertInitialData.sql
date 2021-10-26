USE [AspNetDb]
GO

INSERT INTO [dbo].[Banks] VALUES ('Credit Agricole');
INSERT INTO [dbo].[Banks] VALUES ('Morgan Stanley');
INSERT INTO [dbo].[Banks] VALUES ('Bank Of America');
INSERT INTO [dbo].[Banks] VALUES ('Commerzbank AG');
GO

TRUNCATE TABLE [dbo].[Transactions];

INSERT INTO [dbo].[Transactions] VALUES ('JA3246021','Jane Air',1,'CTBAAU2S',1232,GETDATE(),null)
INSERT INTO [dbo].[Transactions] VALUES ('MH7801453','Mike Hummer',2,'J25AJNS7',314,GETDATE(),null)
INSERT INTO [dbo].[Transactions] VALUES ('JD0214565','John Doe',3,'KG48VC7U',981,GETDATE(),null)
INSERT INTO [dbo].[Transactions] VALUES ('MD4831729','Mary Dalles',4,'HV45CF8S',456,GETDATE(),null)
INSERT INTO [dbo].[Transactions] VALUES ('SM4357313','Stan McOliver',3,'FD456TU1',625,GETDATE(),null)
GO

SELECT a.TransactionId,
	a.AccountNumber,
	a.BeneficiaryName,
	b.[BankName],
	a.SwiftCode,
	a.Amount,
	a.TransactionDateTime,
	a.PhotoPath
FROM [dbo].[Transactions] a
INNER JOIN [dbo].[Banks] b ON a.BankId = b.Id
