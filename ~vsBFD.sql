use master
go
create database sqleksempler
go
use sqleksempler
go
create table biler (
id int identity primary key,
regNr nvarchar (8),
Mærke nvarchar (10),
Model nvarchar (10),
årgang int,)