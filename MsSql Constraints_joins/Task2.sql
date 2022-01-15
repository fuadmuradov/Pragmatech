create database Market
use Market
create table Product(
id int Primary key identity,
name nvarchar(50) not null,
price int not null
);

select * from Product

alter table Product
Add brand nvarchar(50)

insert into Product(name, price, brand)
values 
('Iphone X', 2000, 'Apple'),
('Iphone XS', 2100, 'Apple'),
('Iphone XS MAX' , 2200, 'Apple'),
('Iphone 12 mini', 2250, 'Apple'),
('Iphone 12 pro', 2350, 'Apple'),
('Iphone 12 pro max', 2500, 'Apple'),
('Galaxy S9', 1200, 'Samsung'),
('Galaxy S20', 1500, 'Samsung'),
('Galaxy S20 Ultra', 1800, 'Samsung'),
('Galaxy S21', 2000, 'Samsung'),
('Galaxy S21 Ultra', 2100, 'Samsung'),
('Galaxy M52', 1000, 'Samsung'),
('Xiaomi MI9', 1200, 'Xiaomi'),
('Xiaomi MI9 T', 1100, 'Xiaomi'),
('Redmi Note 10', 800, 'Xiaomi'),
('Poco F3', 850, 'Xiaomi'),
('Xiami MI11', 1200, 'Xiaomi');

select * from Product where price > 2000

select AVG(price) from Product

select * from Product where price>(select AVG(price) from Product)

select CONCAT(name, ' ', brand) as ProductInfo from Product where LEN(brand) > 5