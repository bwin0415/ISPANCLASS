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
�K�X int not null check(�K�X>999 and �K�X<1000000),
�m�W nvarchar (50),
�q�� nvarchar (50),
���� nvarchar(50),
¾�� nvarchar(50),
�~�Z int,
�Ыؤ�� datetime default sysdatetime() ,
�ק��� datetime default sysdatetime() ,
�b¾ bit default 1 
)
go
insert into employee Values
(1001,'Tom','0900123451','�Ұs��','��~��',0,default,default,default),
(1002,'Amy','0900123452','�Ұs��','��~��',0,default,default,default),
(1003,'Tim','0900123453','�Ұs��','��~��',0,default,default,default),
(1004,'Andy','0900123454','�Ұs��','��~��',0,default,default,default),
(1005,'Tomas','0900123455','�Ұs��','�ժ�',0,default,default,default),
(1006,'Jack','0900123456','�Ұs��','�ժ�',0,default,default,default),
(1007,'Jaff','0900123457','�Ұs��','�g�z',0,default,default,default),
(1008,'Anne','0900123458','�Ұs��','�g�z',0,default,default,default)
go

select * from employee
go


drop table if exists member
go
create table member 
(Id int primary key identity(1, 1),
�m�W nvarchar (50),
�q�� nvarchar (50),
Email nvarchar (50),
�ͤ� date,
�I�� int,
�K�X int not null check(�K�X>999 and �K�X<10000000),
������ nvarchar (100) not null,
�Ыؤ�� datetime default sysdatetime() ,
�ק��� datetime default sysdatetime() ,
���Ĭ��_ bit default 0 ,
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
���~�W�� nvarchar (100),
���~���O nvarchar (50),
���~���� int,
���~�w�s�q int,
���~�b�~�q int,
�Ыؤ�� datetime default sysdatetime() ,
�ק��� datetime default sysdatetime() ,
�w�U�[ bit default 0,
)
go

insert into product Values
('JohnieWalkerBlackLabelBlendedScotchWhisky(SherryEdition)','�s',640,84,0,default,default,default),
('Monkey Shoulder Blended Malt Whisky','�s',950,24,0,default,default,default),
('Johnnie Walker Green Label 15 Year Old Malt Scotch Whisky','�s',950,36,0,default,default,default),
('Johnnie Walker Blue Label Cask Edition Blended','�s',6300,12,0,default,default,default),
('Royal Salute 21y','�s',2340,32,0,default,default,default),
('Glenfiddich 15 Year Old Distillery Edition Speyside','�s',1400,12,12,default,default,default),
('Singleton 12 Years Old Sherry Single Malt Scotch Whisky','�s',860,72,24,default,default,default),
('�������d12�~��â�s-��~','�s',16800,16,16,default,default,default),
('�������d12�~��â�s-�U�~','�s',16800,16,16,default,default,default),
('�������d8�~��â�s-���~','�s',12800,32,8,default,default,default),
('Dunhill','��',650,150,50,default,default,default),
('�p','��',900,150,150,default,default,default),
('�C�P','��',650,500,150,default,default,default),
('�j��','��',650,500,150,default,default,default),
('�L��','��',420,300,100,DEFAULT,DEFAULT,DEFAULT)
go

select * from product
go

drop table if exists FrieghtNo
go
create table FrieghtNo
(Id int primary key identity(1, 1),
��Z�N�� nvarchar (50) ,
�Ыؤ�� datetime default sysdatetime() ,
�ק��� datetime default sysdatetime() ,
�w������Z bit default 0      
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