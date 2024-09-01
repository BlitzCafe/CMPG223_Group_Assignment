SELECT YEAR(O.Order_Date) AS Year, 
       DATENAME(MONTH, O.Order_Date) AS Month, 
       SUM(I.Price * OD.Quantity_Sold) AS TotalIncome
FROM Order_Details OD 
JOIN [Order] O ON OD.OrderID = O.OrderID 
JOIN Items I ON OD.ItemID = I.ItemID 
WHERE O.Order_Date BETWEEN '2022-01-01' AND '2024-09-01'
GROUP BY YEAR(O.Order_Date), MONTH(O.Order_Date), DATENAME(MONTH, O.Order_Date)
ORDER BY YEAR(O.Order_Date), MONTH(O.Order_Date);
