drop database if exists Homework
go
create database Homework;
go

use Homework
go
drop table if exists employee
go
create table employee 
(Id int identity(1, 1) primary key,
密碼 int not null check(密碼>999 and 密碼<1000000),
姓名 nvarchar (50),
電話 nvarchar (50),
部門 nvarchar(50),
職稱 nvarchar(50),
業績 int,
創建日期 datetime default sysdatetime() ,
修改日期 datetime default sysdatetime() ,
在職 bit default 1 
)
go
insert into employee Values
(1001,'Tom','0900123451','菸酒組','營業員',0,default,default,default),
(1002,'Amy','0900123452','菸酒組','營業員',0,default,default,default),
(1003,'Tim','0900123453','菸酒組','營業員',0,default,default,default),
(1004,'Andy','0900123454','菸酒組','營業員',0,default,default,default),
(1005,'Tomas','0900123455','菸酒組','組長',0,default,default,default),
(1006,'Jack','0900123456','菸酒組','組長',0,default,default,default),
(1007,'Jaff','0900123457','菸酒組','經理',0,default,default,default),
(1008,'Anne','0900123458','菸酒組','經理',0,default,default,default)
go

select * from employee
go


drop table if exists member
go
create table member 
(Id int primary key identity(1, 1),
姓名 nvarchar (50),
電話 nvarchar (50),
Email nvarchar (50),
生日 date,
點數 int,
密碼 int not null check(密碼>999 and 密碼<10000000),
身分證 nvarchar (100) not null,
創建日期 datetime default sysdatetime() ,
修改日期 datetime default sysdatetime() ,
失效為否 bit default 0 ,
)
go

insert into member Values
('Tom','0900123451','test01@gmail.com',  '1993-1-1',    0,1001,'A123456789' ,default,default,default),
('Tommy','0900123452','test02@gmail.com','1986-4-1',10000,1002,'A123456788' ,default,default,default),
('Jacob','0900123453','test03@gmail.com','1979-7-1',  100,1003,'A123456787' ,default,default,default),
('Steve','0900123454','test04@gmail.com','1993-9-1',  200,1004,'A123456786' ,default,default,default),
('Sam','0900123455','test05@gmail.com',  '1989-11-1',3000,1005,'A123456785' ,default,default,default),
('Simon','0900123456','test06@gmail.com','1978-2-1',13000,1006,'A123456784' ,default,default,default),
('Kevin','0900123457','test07@gmail.com','1978-4-1',13445,1007,'A123456783' ,default,default,default)
go

Select* from member

drop table if exists product
go
create table product 
(Id int primary key identity(1, 1),
產品名稱 nvarchar (100),
產品類別 nvarchar (50),
產品價格 int,
產品庫存量 int,
產品在途量 int,
創建日期 datetime default sysdatetime() ,
修改日期 datetime default sysdatetime() ,
已下架 bit default 0,
)
go

insert into product Values
('JohnieWalkerBlackLabelBlendedScotchWhisky(SherryEdition)','酒',640,84,0,default,default,default),
('Monkey Shoulder Blended Malt Whisky','酒',950,24,0,default,default,default),
('Johnnie Walker Green Label 15 Year Old Malt Scotch Whisky','酒',950,36,0,default,default,default),
('Johnnie Walker Blue Label Cask Edition Blended','酒',6300,12,0,default,default,default),
('Royal Salute 21y','酒',2340,32,0,default,default,default),
('Glenfiddich 15 Year Old Distillery Edition Speyside','酒',1400,12,12,default,default,default),
('Singleton 12 Years Old Sherry Single Malt Scotch Whisky','酒',860,72,24,default,default,default),
('金門高粱12年玉璽酒-虎年','酒',16800,16,16,default,default,default),
('金門高粱12年玉璽酒-猴年','酒',16800,16,16,default,default,default),
('金門高粱8年玉璽酒-機年','酒',12800,32,8,default,default,default),
('Dunhill','菸',650,150,50,default,default,default),
('峰','菸',900,150,150,default,default,default),
('七星','菸',650,500,150,default,default,default),
('大衛','菸',650,500,150,default,default,default),
('尊爵','菸',420,300,100,DEFAULT,DEFAULT,DEFAULT)
go

select * from product
go

drop table if exists FrieghtNo
go
create table FrieghtNo
(Id int primary key identity(1, 1),
航班代號 nvarchar (50) ,
創建日期 datetime default sysdatetime() ,
修改日期 datetime default sysdatetime() ,
已取消航班 bit default 0      
)
go
insert into FrieghtNo Values
('B78912',DEFAULT,DEFAULT,DEFAULT),
('AE302',DEFAULT,DEFAULT,DEFAULT),
('B78916',DEFAULT,DEFAULT,DEFAULT),
('B78928',DEFAULT,DEFAULT,DEFAULT),
('B78926',DEFAULT,DEFAULT,DEFAULT),
('AE308',DEFAULT,DEFAULT,DEFAULT),
('B78930',DEFAULT,DEFAULT,DEFAULT),
('B78836',DEFAULT,DEFAULT,1)
go

select * from FrieghtNo
go