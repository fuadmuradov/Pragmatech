--Database Created
--create database Academy
--*********************
-- Table Created
--create table Student(
--StudentID int IDENTITY(100, 1),
--Grade Date,
--Fullname nvarchar(55),
--Birthdate Date,
--Groups nvarchar(50)
--);
--**************************

--select * from Student
--Insert Data*******
--Insert into Student(Grade, Fullname, Birthdate, Groups)
--values ('2005-may-31', 'Kərim Səlimov','1985-mar-11', 'ABC123');

--insert into Student(Grade, Fullname, Birthdate, Groups)
--values 
--('2010-may-31', 'Uzeyir Hacibayov', '1867-jun-12', 'SDF456'),
--('2011-may-31', 'Muslum Maqamayev', '1965-sep-12', 'ABC123'),
--('2012-may-31', 'Akif Islamzade', '1898-oct-12', 'SDF456'),
--('2012-may-31', 'Huseyn Arif', '1901-dec-12', 'RTY789');
--******************

--Between, AND**************
--select * from Student where StudentID Between 108 and 110
---- OR********
--select * from Student where StudentID = 103 or Fullname = 'Uzeyir Hacibayov'
-- IN **********
--select StudentID, Fullname from Student where StudentID IN(103,109,111)
--LiKE**************
--select Fullname, Groups from Student where Fullname LIKE('M%') or Groups LIke('%789')

--ORDER BY************
--select Fullname, Grade, Groups from Student Order by Fullname ASC
--select Fullname, Grade, Groups from Student Order by Fullname DESC

-- FETCH*************
--select Fullname, Grade, Groups from Student Order by Fullname ASC
--select Fullname, Grade, Groups from Student Order by Fullname ASC offset 3 rows


--TOP****************
--select top 3 Fullname, Groups from Student Order By Fullname Asc

--Update Rows*************
--update Student 
--set Fullname = 'James Bond' where StudentID = 105;

--Delete Rows*********
--delete Student where StudentID = 103


-- Add Column**********
--Alter Table Student 
--ADD sector nvarchar(20) 

--Rename Column***************
--sp_rename 'Student.sector', 'sector2', 'COLUMN'
--sp_rename 'Student.sector2', 'Sector5'

--Delete column in Table************
--alter table Student Drop Column Sector5

--Rename Table*********
--sp_rename 'Student', 'Students'

-- Duplicate Table*********
--select * into Students2 from Students

-- Delete Table****
--Drop Table Students2

--select * from Students

 