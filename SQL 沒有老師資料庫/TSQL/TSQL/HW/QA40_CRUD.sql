-- �H�U�O���u��� :
-- id			first name			last name		salary			birthday
-- 100		�p��						��				30000.5		2000-01-01
-- 200		����						��				40000.8		1998-02-01
-- 300		�j��						�i				45000.9		1995-03-01
-- 400		�p��						��				35000.1		2002-05-01

--  �нm�߼��g�H�U"���O", �Ш��D�N�^��


--  1.  �Ф����� LabDB ��Ʈw�U, �P�� drop ��, �p�G�w�s�b�� table  employee 
drop database if exists LabDB
go
create database LabDB;
go

use LabDB
go

drop table if exists employee
go



--  2.  �Х��إߤ@employee ��ƪ�ȥ]�t �U�C�|�����, id �O primary key  (��� birthday �����n�إ�)
--       id			first name			last name		salary
create table employee 
(Id int primary key ,
firstname nvarchar (50),
lastname nvarchar (50),
salary money
)
go


-- 3.  �Х��λy�k�s�W���u�򥻸��     id			first name			last name		salary
insert employee values
(100,'�p��','��',30000.5),
(200,'����','��',40000.8),
(300,'�j��','�i',45000.9),
(400,'�p��','��',35000.1)
--  4.  �d�ߤ@�U�Ҧ����u���
select * from employee


--  5.  �d�ߤ@�U�~���j��40000 �Ҧ����u���, �å��~���� �Ѥj��p�Ƨ�
select * 
from employee
where salary>40000 
order by salary desc



--  6.  �N��ƪ� employee �W�[�@"�ͤ����", 
--  �դ@�ձN"�ͤ����"�]�� not null �M null ���t�O, ���G���P������?
alter table employee
   add --birthday_notnull date not null,
   --ALTER TABLE �u���\�[�J�i�]�t Null �Τw���w DEFAULT �w�q����Ʀ�A�Υ[�J��
   --��Ʀ�O�ѧO�ήɶ��W�O��Ʀ�A�Ϊ̡A�p�G�W�z���󳣤��ŦX�A��ƪ�N�����O
   --�Ū��A�H���\�[�J����Ʀ�C��Ʀ� 'birthday_notnull' �L�k�[�J�ܫD�ťո��
   --�� 'employee'�A�]�������ŦX�o�Ǳ���C
        birthday_null date null
go


--  7.  �@���u�s�� �ק�/�W�[  �ͤ���
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
-- 8.  �p��@�U�Ҧ����u�~���`�M
select 
sum(salary)as �~���`�M
from employee
go

-- 9.  �p��@�U���u�ӧO���~��(�~��~�Y�i)
select DATEDIFF(YEAR, employee.birthday_null,getdate()) as ��
from employee
go



-- 10. �ЦC�L�X�~��̤֭��u���Ҧ����
select*from employee
where salary=(select MIN(salary) as �̤��~�� from employee)



-- 11.  �ЧR�� ���p�� �H�Ƹ��
delete employee
where salary=(select MIN(salary) as �̤��~�� from employee)
select*from employee





-- ú��@�~�бH��@�U�H�c :
-- Email : jungan0914@gmail.com
