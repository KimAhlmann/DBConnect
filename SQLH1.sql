use master
SET DATEFORMAT dmy;  
go
drop database sqleksempler
create database sqleksempler
go

use sqleksempler
go

create table kunder


 (
id int identity primary key,
navn nvarchar(35),
adr nvarchar(50),
regNr nvarchar (8),
Mærke nvarchar (10),
Model nvarchar (10),
Brændstofstype nvarchar (10),
årgang int,
KM int,
dato datetime default getdate()
)
go

--select * from kunder
--truncate table kunder