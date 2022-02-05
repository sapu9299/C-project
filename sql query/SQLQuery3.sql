

create table orders(
ord_no int primary key,
salesman_id int  references Salesman(salesman_id),
purch_amt decimal(8,2),
order_date date, 
customer_id int references customer(customer_id),

)
insert into orders values(70001,5002,150.5,'2012-10-05',3005)
insert into orders values(70009,5005,270.65,'2012-09-10',3001)
insert into orders values(70002,5001,65.26,'2012-10-05',3002)
insert into orders values(70004,5003,110.5,'2012-08-17',3009)
insert into orders values(70005,5001,2400.6,'2012-07-27',3007)
insert into orders values(70010,5006,1983.43,'2012-10-10',3004)
insert into orders values(70012,5002,250.45,'2012-06-27',3008)
insert into orders values(70011,5007,75.29,'2012-08-17',3003)


drop table orders
select * from orders