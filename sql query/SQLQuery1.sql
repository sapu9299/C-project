create database sapana
--creating database
create database TutorialDB

--creating table 
create table student(
Rollno int,
Name varchar(25),
Marks int,
city varchar(50)
)

--inserting row into table
insert into student values(1,'sapana',300,'yavatmal')
insert into student values(2,'shital',200,'wani')
insert into student values(3,'sonal',400,'yevti')
insert into student values(4,'samiksha',100,'yavatmal')
insert into student values(5,'ketki',300,'yavaal','SSJ')

--deleting from table
delete from student where marks=300 or city='yavatmal'
delete from student where marks=300 and city='yavatmal'

--adding column to existing table
alter table student add school varchar(50)

--updating table row/rows
update student set school='VVM' where city='yavaal'


--viewing table
select * from student