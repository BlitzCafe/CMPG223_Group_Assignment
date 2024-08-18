CREATE TABLE [dbo].[tblCustomer] (
    [CustomerID]  INT        NOT NULL,
    [Last_Name]   NCHAR (30) NULL,
    [First_Name]  NCHAR (30) NULL,
    [CellNo]      NCHAR (10) NULL,
    [Date_Joined] DATETIME NULL,
    PRIMARY KEY CLUSTERED ([CustomerID] ASC)
);

