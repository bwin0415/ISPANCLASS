-- 請練習撰寫底下指令 : 使用 Northwind.Products 產品資料表

-- Step1 確定打開的是 Northwind 資料庫 
use Northwind;
go
select* from Products 

-- Step2 請列出單價最高的前三項產品。
select top 3 ProductName from Products 
order by UnitPrice  desc;


-- Step3 請列出產品的平均單價, 平均庫存, 平均在途。

select
AVG(UnitPrice) as 平均單價,
AVG(UnitsInStock) as 平均庫存,
AVG(UnitsOnOrder) as 平均在途
from Products 



-- Step4 請列出產品的最高單價, 最高庫存, 最高在途。
select
max(UnitPrice) as 最高單價,
max(UnitsInStock) as 最高庫存,
max(UnitsOnOrder) as 最高在途
from Products 




-- Step5 請列出各類產品的平均單價。
select
 CategoryID,
avg(UnitPrice) as 平均單價,
avg(UnitsInStock) as 平均庫存,
avg(UnitsOnOrder) as 平均在途
from Products 
group by CategoryID


-- Step6 挑選類別編號(CategoryID)為 1, 4, 8 為範圍, 計算挑選範圍內產品的平均單價, 平均庫存, 平均在途。
select
 CategoryID,
avg(UnitPrice) as 平均單價,
avg(UnitsInStock) as 平均庫存,
avg(UnitsOnOrder) as 平均在途
from Products 
where CategoryID in(1,4,8)
group by CategoryID





-- Step7 請列出平均單價最高的前三類產品。
select top 3
 CategoryID,
avg(UnitPrice) as 平均單價,
avg(UnitsInStock) as 平均庫存,
avg(UnitsOnOrder) as 平均在途
from Products 
group by CategoryID
order by 平均單價 desc



-- Step8 找出 價格最高 的產品 (使用 TOP 關鍵字)
select top 1 *
from Products
order by UnitPrice desc


-- Step9 找出 價格最低 的產品 (使用 TOP 關鍵字)
select top 1 *
from Products
order by UnitPrice asc


-- Step10 使用 MIN() 關鍵字改寫，取得價格最低產品單價是多少？
select *
from Products
where UnitPrice=(select min(UnitPrice) as 最低單價 from Products)




--	Steve 老師的提問社團 iCoding : https://www.facebook.com/groups/icoding
--  email : jungan0914@gmail.com



