CREATE TABLE [dbo].[tblLoyaltyTransactions]
(
	[LoyaltyTransactionID] INT NOT NULL PRIMARY KEY, 
    [OrderID] INT NULL, 
    [CustomerID] INT NULL, 
    [Running_Point_Balance] REAL NULL
)
