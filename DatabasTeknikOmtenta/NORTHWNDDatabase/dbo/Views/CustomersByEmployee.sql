CREATE VIEW [dbo].[CustomersByEmployee]
	AS SELECT        Employees.FirstName, Employees.LastName, Customers.CompanyName, Customers.ContactName
FROM            Customers INNER JOIN
                         Orders ON Customers.CustomerID = Orders.CustomerID INNER JOIN
                         Employees ON Orders.EmployeeID = Employees.EmployeeID

GROUP BY	  Employees.FirstName, Employees.LastName, Customers.CompanyName, Customers.ContactName