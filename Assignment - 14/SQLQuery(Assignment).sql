create database Players
use Players

create table Player
(PlayerId int primary key,
FirstName nvarchar(50)not null,
LastName nvarchar(50)not null,
JerseyNumber int,
Position nvarchar(50)not null,
Team nvarchar(50) not null)

insert into Player values(1,'Viya','Gandhi',6,'middle blocker','winner')

select * from Player