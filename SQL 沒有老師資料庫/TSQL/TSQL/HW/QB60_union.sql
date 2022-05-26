-- �нm�߼��g���U���O�A�ϥ� AdventureWorks.Sales.SalesPerson ��Ʈw
-- ����� BusinessEntityID <=286 �M >=280 ���j�����select
-- �[�� row ���ܤ�



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





--	Steve �Ѯv�����ݪ��� iCoding : https://www.facebook.com/groups/icoding
--  email : jungan0914@gmail.com