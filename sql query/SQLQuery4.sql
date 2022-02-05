use Sales

create table customer(
Customer_id int primary key,
customer_name varchar(30),
city varchar(15),
grade int,
salesman_id int references Salesman(salesman_id)
)


insert into customer values(3002,'Nick Rimando','New York',100,5001)
insert into customer values(3007,'Brad Davis','New York',200,5001)
insert into customer values(3005,'Graham Zusi','California',200,5002)
insert into customer values(3008,'Julian Green','London',300,5002)
insert into customer values(3004,'Fabian Johnson','Paris',300,5006)
insert into customer values(3009,'Geoff Cameron','Berlin',100,5003)
insert into customer values(3003,'Jozy Altidor','Moscow',200,5007)
insert into customer values(3001,'Brad Guzan','London',100,5005)

select * from customer