create database COMPONY

use COMPONY

create table Customer(
c_ID int Primary key identity(100, 1),
Name nvarchar(30) not null,
Surname nvarchar(50) not null,
Salary int
);
 


insert into Customer(Name, Surname, Salary)
 values
 ('Memmed', 'Araz', 2000),
('Mikail', 'Musviq', 1500), 
('BAxtiyar', 'Vahabzade', 1900),
('Uzeyir', 'Hacibeyov', 2550),
('Akif', 'Islamzede', 1950),
('Huseyn', 'Javid', 1800),
('Mehdi', 'Huseynzade', 1500),
('Huseyn', 'Arif', 1900),
('Ramiz', 'Rovsan', 2500),
('Nizami', 'Gencevi', 1400),
('Sabir', 'Rustemxanli', 1900);

select * from Customer

update Customer
set Salary = 2400 where c_ID = 100;

select AVG(Salary) as Avarage from Customer

select Name from Customer where Salary > (select avg(Salary) from Customer)



select MAX(Salary) from Customer;

select MIN(Salary), Name from Customer;

select Name, Surname, Salary from Customer where Salary = (select max(Salary) from Customer)

select Name, Surname, Salary from Customer where Salary = (select min(Salary) from Customer)

create table Position(
ID int Primary key identity,
Name nvarchar(50)
);

insert into Position(Name) 
values
('HR'),
('IT'),
('Accountment'),
('Finance'),
('Marketing'),
('Ope_Man');

select * from Position

Alter table Customer 
ADD pos_id int

Alter table Customer
ADD Foreign key(pos_id) references Position(id)

update Customer
set pos_id = 3 where c_ID = 108

select * from Customer

select Customer.Name, Customer.Surname, Position.Name
from Customer
Join Position on Customer.pos_id =Position.ID