-- 以下是員工資料 :
-- id			first name			last name		salary			birthday
-- 100		小明						王				30000.5		2000-01-01
-- 200		中明						李				40000.8		1998-02-01
-- 300		大明						張				45000.9		1995-03-01
-- 400		小花						陳				35000.1		2002-05-01

--  請練習撰寫以下"指令", 請依題意回答


--  1.  請切換至 LabDB 資料庫下, 同時 drop 掉, 如果已存在的 table  employee 
drop database if exists LabDB
go
create database LabDB;
go

use LabDB
go

drop table if exists employee
go



--  2.  請先建立一employee 資料表僅包含 下列四個欄位, id 是 primary key  (欄位 birthday 先不要建立)
--       id			first name			last name		salary
create table employee 
(Id int primary key ,
firstname nvarchar (50),
lastname nvarchar (50),
salary money
)
go


-- 3.  請先用語法新增員工基本資料     id			first name			last name		salary
insert employee values
(100,'小明','王',30000.5),
(200,'中明','李',40000.8),
(300,'大明','張',45000.9),
(400,'小花','陳',35000.1)
--  4.  查詢一下所有員工資料
select * from employee


--  5.  查詢一下薪水大於40000 所有員工資料, 並用薪水欄 由大到小排序
select * 
from employee
where salary>40000 
order by salary desc



--  6.  將資料表 employee 增加一"生日欄位", 
--  試一試將"生日欄位"設為 not null 和 null 的差別, 結果不同為什麼?
alter table employee
   add --birthday_notnull date not null,
   --ALTER TABLE 只允許加入可包含 Null 或已指定 DEFAULT 定義的資料行，或加入的
   --資料行是識別或時間戳記資料行，或者，如果上述條件都不符合，資料表就必須是
   --空的，以允許加入此資料行。資料行 'birthday_notnull' 無法加入至非空白資料
   --表 'employee'，因為它不符合這些條件。
        birthday_null date null
go


--  7.  一員工編號 修改/增加  生日資料
update employee  
SET  birthday_null = '2000-01-01'
from employee
where Id =100

update employee  
SET  birthday_null = '1998-02-01'
from employee
where Id =200
update employee  
SET  birthday_null = '1995-03-01'
from employee
where Id =300
update employee  
SET  birthday_null = '2002-05-01'
from employee
where Id =400
go
-- 8.  計算一下所有員工薪水總和
select 
sum(salary)as 薪水總和
from employee
go

-- 9.  計算一下員工個別的年紀(年減年即可)
select DATEDIFF(YEAR, employee.birthday_null,getdate()) as 歲
from employee
go



-- 10. 請列印出薪資最少員工的所有資料
select*from employee
where salary=(select MIN(salary) as 最少薪水 from employee)



-- 11.  請刪除 王小明 人事資料
delete employee
where salary=(select MIN(salary) as 最少薪水 from employee)
select*from employee





-- 繳交作業請寄到一下信箱 :
-- Email : jungan0914@gmail.com
