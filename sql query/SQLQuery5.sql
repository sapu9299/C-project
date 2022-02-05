select * from Salesman

select name,commission from Salesman

select order_date,salesman_id,ord_no,purch_amt from orders

select name,city from Salesman where city='Paris'

select *from customer where grade=200

select ord_no,order_date,purch_amt from orders where salesman_id=5001

--

select Avg(purch_amt) from orders

select count(Distinct salesman_id) from orders

select count(*) from customer

select max(purch_amt) from orders

select city,max(grade) from customer group by city

select order_date,max(purch_amt) from orders group by order_date,customer_id


