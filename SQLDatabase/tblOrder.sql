CREATE TABLE [dbo].[tblOrder]
(
	[OrderID] INT NOT NULL PRIMARY KEY, 
    [Order_Date] TIME NULL, 
    [Is_Paid] BINARY(50) NULL, 
    [LoyaltyPoints_Used] BINARY(50) NULL
)
