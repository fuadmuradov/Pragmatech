create database Parfums

use Parfums

create table Category(
id int Primary key identity,
Name Nvarchar(50) not null
);

select * from Category

create procedure insert_category 
@Name nvarchar(50)
as
insert into Category(Name) values(@Name);

execute insert_category 'Tester'


create table Brand(
id int Primary key identity,
Name nvarchar(100) not null
);

-- 1
create procedure insert_brend 
@Name nvarchar(50)
as
insert into Brand(Name) values(@Name);

execute insert_brend 'Ajmal'
execute insert_brend 'Balenciaga'
execute insert_brend 'Alexandre J'
execute insert_brend 'Chanel'
execute insert_brend 'Antonio Banderas'
execute insert_brend 'Dolce & Gabbana'
execute insert_brend 'Avon'
execute insert_brend 'Bentley'
execute insert_brend 'Escada'
execute insert_brend 'Fendi'
execute insert_brend 'Ferrari'
execute insert_brend 'Shalk'

select * from Brand

select * from Category

create table Parfum(
id int Primary key identity,
Name nvarchar(100),
Price int,
Comment nvarchar(500),
category_id int,
brand_id int,
Foreign key(category_id) references Category(id),
Foreign key(brand_id) references Brand(id)
);

create procedure insert_parfum
@Name nvarchar(100),
@Price int,
@Comment nvarchar(500),
@cat_id int,
@bra_id int
as
Insert into Parfum(Name, Price, Comment, category_id, brand_id)
values(@Name, @Price, @Comment, @cat_id, @bra_id)


execute insert_parfum 'Aurum Winter', 146, 'Ajnal Parfume', 3, 2
execute insert_parfum 'Florabotanica', 277, 'Balenciaga sweet parfume', 3, 2
execute insert_parfum 'Coromondel', 678, 'Chanel Women Parfume', 2, 5
execute insert_parfum 'Blue Seduction', 173, 'Antonio Banderas Man Parfume', 3, 6
execute insert_parfum 'Dolce Shine', 92, 'Dolce & Gabbana woman Parfume', 1, 7
execute insert_parfum 'Today L EDP', 59, 'Avon classic Parfume', 3, 8
execute insert_parfum 'Bentley for men Black edition', 137, 'Bentley for men Black Edition Parfume', 3, 9

select * from brand

select * from Parfum



create table Sales(
id int Primary key identity,
Amount int not null,
parfum_id int,
Foreign key(parfum_id) references Parfum(id)
);

select * from Parfum

insert into Sales(Amount, parfum_id) 
values
(3,1),
(5,2),
(10,3),
(8,4),
(15, 5),
(12, 6),
(21, 10),
(13,11);



-- Contact Table
create table Contact(
id int Primary key identity,
Telefon nvarchar(50),
Mobile nvarchar(50),
Whatsapp nvarchar(50),
Instagram nvarchar(50),
Facebook nvarchar(50),
Email nvarchar(50)
)

select * from Parfum


-- 2

create view ParfumInfo 
as
select Parfum.id, Parfum.Name, Parfum.Price, Brand.Name as Brand, Category.Name as Category from
Parfum
Join Brand on Parfum.brand_id = Brand.id
Join Category on Parfum.category_id = Category.id

select * from ParfumInfo

-- 3

-- Sales View
create view SalesInfo
as
select Sales.id, Sales.Amount as S_Count, Parfum.Name as Name, Brand.Name as Brand, Category.Name as Category, Parfum.Price
from Sales
Join Parfum on Sales.parfum_id = Parfum.id
Join Brand on Parfum.brand_id = Brand.id
Join Category on Parfum.category_id = Category.id

select * from SalesInfo

--4
Create procedure BetweenSalesInfo
@LowNumber int,
@HighNumber int
as
select Sales.id, Sales.Amount as S_Count, Parfum.Name as Name, Brand.Name as Brand, Category.Name as Category, Parfum.Price
from Sales
Join Parfum on Sales.parfum_id = Parfum.id
Join Brand on Parfum.brand_id = Brand.id
Join Category on Parfum.category_id = Category.id
where Sales.Amount > @LowNumber and Sales.Amount<@HighNumber

execute BetweenSalesInfo 5, 20

--5

Create procedure SearchSalesInfo
@SearchText nvarchar(max)=null,
@LowNumber int,
@HighNumber int
as
select Sales.id, Sales.Amount as S_Count, Parfum.Name as Name, Brand.Name as Brand, Category.Name as Category, Parfum.Price
from Sales
Join Parfum on Sales.parfum_id = Parfum.id
Join Brand on Parfum.brand_id = Brand.id
Join Category on Parfum.category_id = Category.id
where Sales.Amount > @LowNumber and Sales.Amount<@HighNumber and 
(Parfum.Name like '%' + ISNULL(@SearchText, Parfum.Name) + '%' or
 Brand.Name like '%' + ISNULL(@SearchText, Brand.Name) + '%' or
 Category.Name like '%' + ISNULL(@SearchText, Category.Name) + '%')

 execute SearchSalesInfo 'etir', 1, 1000;

 select * from ParfumInfo