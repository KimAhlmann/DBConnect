use master
go
create database sqleksempler
go
use sqleksempler
go
create table biler (
id int identity primary key,
regNr nvarchar (8),
M�rke nvarchar (10),
Model nvarchar (10),
�rgang int,)