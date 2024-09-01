SELECT TOP 5 OD.ItemID, I.Description, SUM(OD.Quantity_Sold) AS TotalQuantity 
                    FROM Order_Details OD
                    JOIN [Order] O ON OD.OrderID = O.OrderID 
                    JOIN Items I ON OD.ItemID = I.ItemID 
                    WHERE O.Order_Date BETWEEN '2023-01-01' AND '2024-09-01' 
                    GROUP BY OD.ItemID, I.Description 
                    ORDER BY TotalQuantity DESC