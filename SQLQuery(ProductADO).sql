create database ProductsDb
use ProductsDb

create table Product
(Id int primary key,
Name nvarchar(50)not null,
Price float not null)

insert into Product values(1,'Earbuds',1250.45)

select * from Product