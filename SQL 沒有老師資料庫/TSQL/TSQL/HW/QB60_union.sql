-- 請練習撰寫底下指令，使用 AdventureWorks.Sales.SalesPerson 資料庫
-- 用欄位 BusinessEntityID <=286 和 >=280 分隔成兩個select
-- 觀察 row 的變化



--	Using UNION ALL : to return all rows from both tables " including duplicates "

use LabDB2
go

select * 
from AdventureWorks.Sales.SalesPerson
where BusinessEntityID<=286
union all
select * 
from AdventureWorks.Sales.SalesPerson
where BusinessEntityID>=280


--	Using UNION : to return all rows from both tables " excluding duplicates "


select * 
from AdventureWorks.Sales.SalesPerson
where BusinessEntityID<=286
union
select * 
from AdventureWorks.Sales.SalesPerson
where BusinessEntityID>=280


--	Using INTERSECT : to return only rows found in both tables


select * 
from AdventureWorks.Sales.SalesPerson
where BusinessEntityID<=286
intersect
select * 
from AdventureWorks.Sales.SalesPerson
where BusinessEntityID>=280


--	Using EXCEPT : to return only rows from left table

select * 
from AdventureWorks.Sales.SalesPerson
where BusinessEntityID<=286
EXCEPT
select * 
from AdventureWorks.Sales.SalesPerson
where BusinessEntityID>=280



--	Reverse position of tables, return only rows from left table

select * 
from AdventureWorks.Sales.SalesPerson
where BusinessEntityID>=280
EXCEPT
select * 
from AdventureWorks.Sales.SalesPerson
where BusinessEntityID<=286





--	Steve 老師的提問社團 iCoding : https://www.facebook.com/groups/icoding
--  email : jungan0914@gmail.com