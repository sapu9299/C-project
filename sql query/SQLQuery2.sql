create database Sales

--creating table Salesman
create table Salesman(
salesman_id int primary key,
commission real,
name varchar(30),
city varchar(40)
)
insert into Salesman values(5001,0.15,'James Hoog','New York')
insert into Salesman values(5002,0.13,'Nail Knite','Paris')
insert into Salesman values(5005,0.11,'Pit Alex','London')
insert into Salesman values(5006,0.14,'Mc Lyon','Paris')
insert into Salesman values(5007,0.13,'Paul Adam','Rome')
insert into Salesman values(5003,0.12,'Lauson','San Jose')

drop table Salesman

select * from Salesman