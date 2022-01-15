use Academy

create table department(
dep_id int primary key identity,
dep_name nvarchar(50) not null
);

insert into department(dep_name) 
values
('HR'),
('IT'),
('Accountment'),
('Finance'),
('Marketing'),
('Ope_Man');

select * from department

create table employee(
emp_id int primary key identity,
emp_name nvarchar(30),
emp_surname nvarchar(50),
dep_id int,
Foreign key(dep_id) references department(dep_id)
);



insert into employee(emp_name, emp_surname, dep_id)
values
('Memmed', 'Araz', 5),
('Mikail', 'Musviq', 2), 
('BAxtiyar', 'Vahabzade', 6),
('Uzeyir', 'Hacibeyov', 1),
('Akif', 'Islamzede', 2),
('Huseyn', 'Javid', 3),
('Mehdi', 'Huseynzade', 4),
('Huseyn', 'Arif', 5);

insert into employee(emp_name, emp_surname)
values
('Ramiz', 'Rovsan'),
('Nizami', 'Gencevi'),
('Sabir', 'Rustemxanli');


select * from  department

-- INNER JOIN
select employee.emp_name, employee.emp_surname, department.dep_name
from employee 
join department on department.dep_id=employee.dep_id;

--LEFT JOIN
select employee.emp_id, employee.emp_name, employee.emp_surname, department.dep_name
from employee 
left join department on employee.dep_id = department.dep_id;

--RIGHT JOIN
select employee.emp_id, employee.emp_name, employee.emp_surname, department.dep_name
from employee 
Right join department on employee.dep_id = department.dep_id;

--CROSS JOIN
select employee.emp_id, employee.emp_name, employee.emp_surname, department.dep_name
from employee 
cross join department;